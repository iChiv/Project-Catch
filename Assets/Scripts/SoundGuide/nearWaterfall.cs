using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class nearWaterfall : MonoBehaviour
{
    public GameObject player;
    public AudioSource closeWf;

    bool guide6 = true;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player && guide6)
        {
            closeWf.Play();
            guide6 = false;
        }
    }
}
