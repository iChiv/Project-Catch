using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class nearGear : MonoBehaviour
{
    public GameObject player;
    public AudioSource closeGear;

    bool guide9 = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player && guide9)
        {
            closeGear.Play();
            guide9 = false;
        }
    }
}
