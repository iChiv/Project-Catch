using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class leaveWhiteRoom : MonoBehaviour
{
    public GameObject player;
    public AudioSource leaveRoom;

    bool guide4 = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player && guide4)
        {
            leaveRoom.Play();
            guide4 = false;
        }
    }
}
