using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

[ExecuteInEditMode]
public class PressurePlateScript : MonoBehaviour
{
    [HideInInspector]
    public string[] options;
    [HideInInspector]
    public int index;
    [HideInInspector]
    public bool isInteractive;
    [HideInInspector]
    public UnityEvent TagCollisionEnter;
    [HideInInspector]
    public UnityEvent TagCollisionStay;
    [HideInInspector]
    public UnityEvent TagCollisionExit;
    [HideInInspector]
    public bool ShowCollisionEnterEvent;
    [HideInInspector]
    public bool ShowCollisionStayEvent;
    [HideInInspector]
    public bool ShowCollisionExitEvent;
    [HideInInspector]
    public bool DisableAudio;
    [HideInInspector]
    public bool DisableAnimations;

    Animator anim;
    AudioSource source;

    private void Awake()
    {
        anim = this.GetComponent<Animator>();
        source = this.GetComponent<AudioSource>();
    }

    private void Update()
    {
        options = UnityEditorInternal.InternalEditorUtility.tags; // Get all available tags from the Editor
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == options[index]) // If colliding gameObject has the same tag as the selected tag of this script
        {

            if (!DisableAudio)
            {
                source.pitch = 2f;
                source.Play();
            }

            if (!DisableAudio)
            {
                anim.Play("PressurePlate_Press");
            }

            TagCollisionEnter.Invoke(); // Run all functions assigned to the 'On Tag Collision Enter' UnityEvent

        }

    }

    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.tag == "Object")
        {

            if (!DisableAudio)
            {
                source.pitch = 1.8f;
                source.Play();
            }

            if (!DisableAnimations)
            {
                anim.Play("PressurePlate_Release");
            }

            TagCollisionExit.Invoke();
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        TagCollisionStay.Invoke();
    }

}
