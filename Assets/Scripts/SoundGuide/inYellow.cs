using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class inYellow : MonoBehaviour
{
    public GameObject player;
    public AudioSource yellowRoom;

    bool guide13 = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player && guide13)
        {
            yellowRoom.Play();
            guide13 = false;
        }
    }
}
