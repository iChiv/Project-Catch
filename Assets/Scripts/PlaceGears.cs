using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceGears : MonoBehaviour
{
    public GameObject mainCam;
    RaycastHit hit;
    int layerMask = 1 << 6;
    //[SerializeField] GameObject GearBox;
    [SerializeField] GameObject GearCheck1;
    [SerializeField] GameObject GearCheck2;
    [SerializeField] GameObject GearCheck3;
    [SerializeField] GameObject GearReady1;
    [SerializeField] GameObject GearReady2;
    [SerializeField] GameObject GearReady3;
    [SerializeField] GameObject GearOK1;
    [SerializeField] GameObject GearOK2;
    [SerializeField] GameObject GearOK3;

    [SerializeField] GameObject rec;


    [SerializeField] GameObject GearSpic;
    [SerializeField] GameObject GearSpicPro;
    [SerializeField] GameObject GearDpic;
    [SerializeField] GameObject GearDpicPro;

    // Update is called once per frame
    void Update()
    {
        //if(GearSpic.activeSelf == true || GearDpic.activeSelf == true)
        //{
        //    GearBox.GetComponent<Renderer>().enabled = true;
        //}
        //else
        //{
        //    GearBox.GetComponent<Renderer>().enabled = false;
        //}

        if(Physics.Raycast(mainCam.transform.position,mainCam.transform.forward,out hit,50, layerMask)&& GearSpic.activeSelf == true)
        {
            if(hit.collider.gameObject == GearCheck1)
            {
                GearReady1.GetComponent<MeshRenderer>().enabled = true;
                if(Input.GetMouseButtonDown(0))
                {
                    GearOK1.GetComponent<MeshRenderer>().enabled = true;
                    GearReady1.GetComponent<MeshRenderer>().enabled = false;
                    GearSpic.SetActive(false);
                    GearSpicPro.SetActive(false);
                }
            }
        }
        else
        {
            GearReady1.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
