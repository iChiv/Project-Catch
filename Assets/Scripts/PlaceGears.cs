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
    [SerializeField] GameObject GearReady1D;
    [SerializeField] GameObject GearReady2;
    [SerializeField] GameObject GearReady3;
    [SerializeField] GameObject GearReady3D;
    [SerializeField] GameObject GearOK1_S;
    [SerializeField] GameObject GearOK1_D;
    [SerializeField] GameObject GearOK1_Dxxx;
    [SerializeField] GameObject GearOK2;
    [SerializeField] GameObject GearOK3_S;
    [SerializeField] GameObject GearOK3_D;

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
                    GearOK1_S.SetActive(true);
                    GearReady1.GetComponent<MeshRenderer>().enabled = false;
                    GearSpic.SetActive(false);
                    GearSpicPro.SetActive(false);
                }
            }
            if (hit.collider.gameObject == GearCheck2)
            {
                GearReady2.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    GearOK2.SetActive(true);
                    GearReady2.GetComponent<MeshRenderer>().enabled = false;
                    GearSpic.SetActive(false);
                    GearSpicPro.SetActive(false);
                }
            }
            if (hit.collider.gameObject == GearCheck3)
            {
                GearReady3.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    GearOK3_S.SetActive(true);
                    GearReady3.GetComponent<MeshRenderer>().enabled = false;
                    GearSpic.SetActive(false);
                    GearSpicPro.SetActive(false);
                }
            }
        }

        else if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 50, layerMask) && GearDpic.activeSelf == true)
        {
            if(hit.collider.gameObject == GearCheck1)
            {
                GearReady1D.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    GearOK1_Dxxx.SetActive(true);
                    GearReady1D.GetComponent<MeshRenderer>().enabled = false;
                    GearDpic.SetActive(false);
                    GearDpicPro.SetActive(false);
                }
            }
            if (hit.collider.gameObject == GearCheck3)
            {
                GearReady3D.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    GearOK3_D.SetActive(true);
                    GearReady3D.GetComponent<MeshRenderer>().enabled = false;
                    GearDpic.SetActive(false);
                    GearDpicPro.SetActive(false);
                }
            }
        }
        else
        {
            GearReady1.GetComponent<MeshRenderer>().enabled = false;
            GearReady1D.GetComponent<MeshRenderer>().enabled = false;
            GearReady2.GetComponent<MeshRenderer>().enabled = false;
            GearReady3.GetComponent<MeshRenderer>().enabled = false;
            GearReady3D.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
