using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureThings : MonoBehaviour
{
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit,50))
        {
            if(hit.collider.tag == "AbleToCapture" && hit.collider.name == "DoorOpen2")
            {
            }
        }
    }
}
