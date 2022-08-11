using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaceBridge : MonoBehaviour
{
    public AudioSource projectSound;
    public GameObject mainCam;
    RaycastHit hit;
    [SerializeField] GameObject cliff1;
    [SerializeField] GameObject cliff2;
    [SerializeField] GameObject cliff3;
    [SerializeField] GameObject cliff4;
    [SerializeField] GameObject cliff5;
    [SerializeField] GameObject cliff6;
    public GameObject bridgeReady;
    public GameObject bridgeOK;
    public GameObject bridgeCheck;
    public GameObject BridgePic;
    public GameObject BridgePicPro;

    //public GameObject BridgePicInProject;

    // Update is called once per frame
    void Update()
    {
        if(BridgePic.activeSelf == true)
        {
            cliff1.GetComponent<MeshRenderer>().enabled = true;
            cliff2.GetComponent<MeshRenderer>().enabled = true;
            cliff3.GetComponent<MeshRenderer>().enabled = true;
            cliff4.GetComponent<MeshRenderer>().enabled = true;
            cliff5.GetComponent<MeshRenderer>().enabled = true;
            cliff6.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            cliff1.GetComponent<MeshRenderer>().enabled = false;
            cliff2.GetComponent<MeshRenderer>().enabled = false;
            cliff3.GetComponent<MeshRenderer>().enabled = false;
            cliff4.GetComponent<MeshRenderer>().enabled = false;
            cliff5.GetComponent<MeshRenderer>().enabled = false;
            cliff6.GetComponent<MeshRenderer>().enabled = false;
        }

        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 50) && BridgePic.activeSelf ==true)
        {
            if(hit.collider.tag == "AbleToPlace" && hit.collider.name == "BridgeBrick")
            {
                bridgeReady.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    projectSound.Play();
                    bridgeOK.SetActive(true);
                    bridgeReady.SetActive(false);
                    BridgePic.gameObject.SetActive(false);
                    BridgePicPro.SetActive(false);
                    cliff1.GetComponent<MeshRenderer>().enabled = false;
                    cliff2.GetComponent<MeshRenderer>().enabled = false;
                    cliff3.GetComponent<MeshRenderer>().enabled = false;
                    cliff4.GetComponent<MeshRenderer>().enabled = false;
                    cliff5.GetComponent<MeshRenderer>().enabled = false;
                    cliff6.GetComponent<MeshRenderer>().enabled = false;
                }
            }
            else
            {
                bridgeReady.SetActive(false);
            }

        }      
    }

    private void OnDisable()
    {
        cliff1.GetComponent<MeshRenderer>().enabled = false;
        cliff2.GetComponent<MeshRenderer>().enabled = false;
        cliff3.GetComponent<MeshRenderer>().enabled = false;
        cliff4.GetComponent<MeshRenderer>().enabled = false;
        cliff5.GetComponent<MeshRenderer>().enabled = false;
        cliff6.GetComponent<MeshRenderer>().enabled = false;
    }
}
