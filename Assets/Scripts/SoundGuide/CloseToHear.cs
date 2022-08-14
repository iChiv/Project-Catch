using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseToHear : MonoBehaviour
{
    public GameObject player;
    public AudioSource AudioSource;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            AudioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            AudioSource.Stop();        }
    }
}
