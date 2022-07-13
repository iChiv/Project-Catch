using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBridge : MonoBehaviour
{
    RaycastHit hit;
    public GameObject bridgeReady;
    public GameObject bridgeOK;
    public GameObject bridgeCheck;
    
    //public GameObject BridgePicInProject;

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit, 50))
        {
            if(hit.collider.tag == "AbleToPlace" && hit.collider.name == "BridgeBrick")
            {
                bridgeReady.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    bridgeOK.SetActive(true);
                    bridgeReady.SetActive(false);
                }
            }
            else
            {
                bridgeReady.SetActive(false);
            }

        }
        
    }
}
