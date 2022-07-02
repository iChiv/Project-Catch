using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CanEditMultipleObjects]
[CustomEditor(typeof(PressurePlateScript))]
public class Editor_PressurePlateA : Editor
{

    PressurePlateScript editorTarget;

    SerializedProperty index;
    SerializedProperty isInteractive;
    SerializedProperty TagCollisionEnter;
    SerializedProperty TagCollisionExit;
    SerializedProperty TagCollisionStay;
    SerializedProperty ShowCollisionEnterEvent;
    SerializedProperty ShowCollisionStayEvent;
    SerializedProperty ShowCollisionExitEvent;
    SerializedProperty DisableAudio;
    SerializedProperty DisableAnimations;

    void OnEnable()
    {
        editorTarget = target as PressurePlateScript;
        index = serializedObject.FindProperty("index");
        isInteractive = serializedObject.FindProperty("isInteractive");
        TagCollisionEnter = serializedObject.FindProperty("TagCollisionEnter");
        TagCollisionExit = serializedObject.FindProperty("TagCollisionExit");
        TagCollisionStay = serializedObject.FindProperty("TagCollisionStay");
        ShowCollisionEnterEvent = serializedObject.FindProperty("ShowCollisionEnterEvent");
        ShowCollisionStayEvent = serializedObject.FindProperty("ShowCollisionStayEvent");
        ShowCollisionExitEvent = serializedObject.FindProperty("ShowCollisionExitEvent");
        DisableAudio = serializedObject.FindProperty("DisableAudio");
        DisableAnimations = serializedObject.FindProperty("DisableAnimations");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.Space();
        isInteractive.boolValue = EditorGUILayout.Toggle("Is Interactive: ", isInteractive.boolValue);
        EditorGUILayout.Space();
        if (isInteractive.boolValue)
        {
            EditorGUILayout.LabelField("Responsivity", EditorStyles.boldLabel);
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Interact with tag: ", GUILayout.MaxWidth(120));
            index.intValue = EditorGUILayout.Popup(index.intValue, editorTarget.options);
            editorTarget.index = index.intValue;
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("On Tag Collision Enter:", GUILayout.MaxWidth(167));
            ShowCollisionEnterEvent.boolValue = EditorGUILayout.Toggle(ShowCollisionEnterEvent.boolValue);
            EditorGUILayout.EndHorizontal();
            if (ShowCollisionEnterEvent.boolValue)
            {
                EditorGUILayout.PropertyField(TagCollisionEnter);
            }
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("On Tag Collision Stay:", GUILayout.MaxWidth(167));
            ShowCollisionStayEvent.boolValue = EditorGUILayout.Toggle(ShowCollisionStayEvent.boolValue);
            EditorGUILayout.EndHorizontal();
            if (ShowCollisionStayEvent.boolValue)
            {
                EditorGUILayout.PropertyField(TagCollisionStay);
            }
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("On Tag Collision Exit:", GUILayout.MaxWidth(167));
            ShowCollisionExitEvent.boolValue = EditorGUILayout.Toggle(ShowCollisionExitEvent.boolValue);
            EditorGUILayout.EndHorizontal();
            if (ShowCollisionExitEvent.boolValue)
            {
                EditorGUILayout.PropertyField(TagCollisionExit);
            }

            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Audio", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(DisableAudio);
            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Animations", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(DisableAnimations);
        }

        serializedObject.ApplyModifiedProperties();
    }

}
