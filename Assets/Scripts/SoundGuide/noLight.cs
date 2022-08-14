using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noLight : MonoBehaviour
{
    public GameObject player;
    public AudioSource noLightSound;

    bool guide15 = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player && guide15)
        {
            noLightSound.Play();
            guide15 = false;
        }
    }
}
