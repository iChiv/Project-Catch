using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlaceGears : MonoBehaviour
{
    public GameObject g1_postion;
    public GameObject g3_postion;

    public GameObject g1dxx_pre;
    public GameObject g3sxx_pre;

    public AudioSource projectSound;
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
    [SerializeField] GameObject GearBox;

    [SerializeField] GameObject GearSpic;
    [SerializeField] GameObject GearSpicPro;
    [SerializeField] GameObject GearDpic;
    [SerializeField] GameObject GearDpicPro;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GearSpic.activeSelf == true || GearDpic.activeSelf == true)
        {
            GearBox.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            GearBox.GetComponent<Renderer>().enabled = false;
        }


        if (Physics.Raycast(mainCam.transform.position,mainCam.transform.forward,out hit,50, layerMask)&& GearSpic.activeSelf == true)
        {
            if(hit.collider.gameObject == GearCheck1)
            {
                GearReady1.GetComponent<MeshRenderer>().enabled = true;
                if(Input.GetMouseButtonDown(0))
                {
                    projectSound.Play();
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
                    projectSound.Play();
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
                    projectSound.Play();
                    //GameObject g3s = GameObject.Instantiate(gear3s_pre,c) as GameObject;
                    //GameObject g3s = Instantiate(g3sxx_pre, transform.position, transform.rotation);
                    //g3s.transform.position = g3_postion.transform.position;
                    GearOK3_S.transform.position = g3_postion.transform.position;
                    GearOK3_S.transform.rotation = g3_postion.transform.rotation;
                    GearOK3_S.SetActive(true);
                    GearOK3_S.GetComponent<DOTweenPath>().DORestart();
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
                    projectSound.Play();
                    //GameObject g1dxxx = Instantiate(g1dxx_pre,transform.position,transform.rotation);
                    //g1dxxx.transform.position = g1_postion.transform.position;
                    GearOK1_Dxxx.transform.position = g1_postion.transform.position;
                    GearOK1_Dxxx.transform.rotation = g1_postion.transform.rotation;
                    GearOK1_Dxxx.SetActive(true);
                    GearOK1_Dxxx.GetComponent<DOTweenPath>().DORestart();
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
                    projectSound.Play();
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
    private void OnDisable()
    {
        GearBox.GetComponent<Renderer>().enabled = false;
    }
}
