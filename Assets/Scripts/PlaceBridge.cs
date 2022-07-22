using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaceBridge : MonoBehaviour
{
    public GameObject mainCam;
    RaycastHit hit;
    public GameObject bridgeReady;
    public GameObject bridgeOK;
    public GameObject bridgeCheck;
    public GameObject BridgePicInProject;
    public GameObject BridgePicInShoot;
    
    //public GameObject BridgePicInProject;

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 50) && BridgePicInProject.activeSelf ==true)
        {
            if(hit.collider.tag == "AbleToPlace" && hit.collider.name == "BridgeBrick")
            {
                bridgeReady.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    bridgeOK.SetActive(true);
                    bridgeReady.SetActive(false);
                    BridgePicInProject.gameObject.SetActive(false);
                    BridgePicInShoot.gameObject.SetActive(false);
                }
            }
            else
            {
                bridgeReady.SetActive(false);
            }

        }
        
    }
}
