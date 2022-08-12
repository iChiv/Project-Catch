using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class nearCliff : MonoBehaviour
{
    public GameObject player;
    public AudioSource closeCliff;

    bool guide5 = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player && guide5)
        {
            closeCliff.Play();
            guide5 = false;
        }
    }
}
