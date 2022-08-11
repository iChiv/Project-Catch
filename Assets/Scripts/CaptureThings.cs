using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureThings : MonoBehaviour
{
    public GameObject mainCam;
    [SerializeField] GameObject REC;
    public AudioSource catchSound;

    RaycastHit hit;
    [SerializeField] GameObject DoorOpen1;
    public GameObject DoorOpen2;
    public GameObject DoorOpen3;
    public GameObject DoorPic;
    public GameObject DoorPicPro;

    public GameObject DoorCapable11;
    public GameObject DoorCapable12;
    public GameObject DoorCapable13;
    public GameObject DoorCapable14;
    public GameObject DoorCapable15;
    public GameObject DoorCapable16;
    public GameObject DoorBox1;
    public GameObject DoorBox2;
    public GameObject DoorBox3;

    public GameObject DoorCapable21;
    public GameObject DoorCapable22;
    public GameObject DoorCapable23;

    //cliff
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject BlockChecked1;
    public GameObject BlockChecked2;
    public GameObject BlockChecked3;

    public GameObject BridgePic;
    public GameObject BridgePicPro;
    int layerMask = 1 << 6;

    //waterfall
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;
    public GameObject CubeChecked1;
    public GameObject CubeChecked2;
    public GameObject CubeChecked3;
    public GameObject CubeChecked4;
    public GameObject CubeChecked5;
    public GameObject CubeOK1;
    public GameObject CubeOK2;
    public GameObject CubeOK3;

    public GameObject CubePic;
    public GameObject CubePicPro;

    //waterfall
    [SerializeField] GameObject Waterfall1;
    [SerializeField] GameObject Waterfall2;
    [SerializeField] GameObject WaterfallCheck1;
    [SerializeField] GameObject WaterfallCheck2;
    
    [SerializeField] GameObject WaterfallPic;
    [SerializeField] GameObject WaterfallPicPro;

    [SerializeField] GameObject wf_s;
    [SerializeField] GameObject wf_sPro;

    //Gear
    [SerializeField] GameObject Gear_s;
    [SerializeField] GameObject Gear_sCheck;

    [SerializeField] GameObject Gear_sPic;
    [SerializeField] GameObject Gear_sPicPro;
    [SerializeField] GameObject Gear_dPic;
    [SerializeField] GameObject Gear_dPicPro;

    [SerializeField] GameObject gearActive1;
    [SerializeField] GameObject gearActive2;
    [SerializeField] GameObject gearActive3;
    [SerializeField] GameObject gearCheck1;
    [SerializeField] GameObject gearCheck1D;
    [SerializeField] GameObject gearCheck2;
    [SerializeField] GameObject gearCheck2D;
    [SerializeField] GameObject gearCheck3;
    [SerializeField] GameObject gearCheck3D;
    [SerializeField] GameObject Gear_S1;
    [SerializeField] GameObject Gear_D1;
    [SerializeField] GameObject Gear_D2;
    [SerializeField] GameObject Gear_S3;
    [SerializeField] GameObject Gear_D3;

    //SUN
    [SerializeField] GameObject Sun;
    [SerializeField] GameObject sunPic;
    [SerializeField] GameObject sunPicPro;

    //color_room
    [SerializeField] GameObject colorDoorBox;
    [SerializeField] GameObject colorDoorCapCheck;
    [SerializeField] GameObject colorDoorPic;
    [SerializeField] GameObject colorDoorPicPro;
    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit,5000,layerMask))
        {
            //Debug.Log(hit.collider.name);
            if (hit.collider.gameObject == DoorOpen2)
            {
                DoorCapable11.GetComponent<MeshRenderer>().enabled = true;
                DoorCapable12.GetComponent<MeshRenderer>().enabled = true;
                DoorCapable13.GetComponent<MeshRenderer>().enabled = true;
                DoorCapable14.GetComponent<MeshRenderer>().enabled = true;
                DoorCapable15.GetComponent<MeshRenderer>().enabled = true;
                DoorCapable16.GetComponent<MeshRenderer>().enabled = true;
                DoorBox1.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    DoorPic.SetActive(true);
                    DoorPicPro.SetActive(true);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                DoorBox1.SetActive(false);
                DoorCapable11.GetComponent<MeshRenderer>().enabled = false;
                DoorCapable12.GetComponent<MeshRenderer>().enabled = false;
                DoorCapable13.GetComponent<MeshRenderer>().enabled = false;
                DoorCapable14.GetComponent<MeshRenderer>().enabled = false;
                DoorCapable15.GetComponent<MeshRenderer>().enabled = false;
                DoorCapable16.GetComponent<MeshRenderer>().enabled = false;
            }
            if (hit.collider.gameObject == DoorOpen1)
            {
                DoorCapable21.GetComponent<MeshRenderer>().enabled = true;
                DoorCapable22.GetComponent<MeshRenderer>().enabled = true;
                DoorCapable23.GetComponent<MeshRenderer>().enabled = true;
                DoorBox2.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    DoorPic.SetActive(true);
                    DoorPicPro.SetActive(true);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                DoorBox2.SetActive(false);
                DoorCapable21.GetComponent<MeshRenderer>().enabled = false;
                DoorCapable22.GetComponent<MeshRenderer>().enabled = false;
                DoorCapable23.GetComponent<MeshRenderer>().enabled = false;
            }
            if (hit.collider.gameObject == DoorOpen3)
            {
                DoorBox3.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    DoorPic.SetActive(true);
                    DoorPicPro.SetActive(true);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                DoorBox3.SetActive(false);
            }
            //cliff
            if (hit.collider.gameObject == Block1)
            {
                BlockChecked1.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    BridgePic.SetActive(true);
                    BridgePicPro.SetActive(true);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                BlockChecked1.SetActive(false);
            }
            if (hit.collider.gameObject == Block2)
            {
                BlockChecked2.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    BridgePic.SetActive(true);
                    BridgePicPro.SetActive(true);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                BlockChecked2.SetActive(false);
            }
            if (hit.collider.gameObject == Block3)
            {
                BlockChecked3.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    BridgePic.SetActive(true);
                    BridgePicPro.SetActive(true);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                BlockChecked3.SetActive(false);
            }
            //waterfall
            if(hit.collider.gameObject == Cube1)
            {
                CubeChecked1.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    CubePic.SetActive(true);
                    CubePicPro.SetActive(true);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                CubeChecked1.SetActive(false);
            }
            if (hit.collider.gameObject == Cube2)
            {
                CubeChecked2.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    CubePic.SetActive(true);
                    CubePicPro.SetActive(true);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                CubeChecked2.SetActive(false);
            }
            if (hit.collider.gameObject == Cube3 && CubeOK1.activeSelf == true)
            {
                CubeChecked3.SetActive(true);
                if (Input.GetMouseButtonDown(0) && CubeOK1.activeSelf == true)
                {
                    catchSound.Play();
                    CubePic.SetActive(true);
                    CubePicPro.SetActive(true);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                CubeChecked3.SetActive(false);
            }
            if (hit.collider.gameObject == Cube4 && CubeOK2.activeSelf == true)
            {
                CubeChecked4.SetActive(true);
                if (Input.GetMouseButtonDown(0) && CubeOK2.activeSelf == true)
                {
                    catchSound.Play();
                    CubePic.SetActive(true);
                    CubePicPro.SetActive(true);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                CubeChecked4.SetActive(false);
            }
            if (hit.collider.gameObject == Cube5 && CubeOK3.activeSelf == true)
            {
                CubeChecked5.SetActive(true);
                if (Input.GetMouseButtonDown(0) && CubeOK3.activeSelf == true)
                {
                    catchSound.Play();
                    CubePic.SetActive(true);
                    CubePicPro.SetActive(true);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                CubeChecked5.SetActive(false);
            }

            //watferfall-proj
            if(hit.collider.gameObject == Waterfall1 && REC.activeSelf==true)
            {
                WaterfallCheck1.GetComponent<MeshRenderer>().enabled = true;
                if(Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    WaterfallCheck1.GetComponent<MeshRenderer>().enabled = false;
                    WaterfallPic.SetActive(true);
                    WaterfallPicPro.SetActive(true);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                }
            }
            else if(hit.collider.gameObject == Waterfall1 && REC.activeSelf == false)
            {
                WaterfallCheck1.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    WaterfallCheck1.GetComponent<MeshRenderer>().enabled = false;
                    wf_s.SetActive(true);
                    wf_sPro.SetActive(true);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                }
            }
            else
            {
                WaterfallCheck1.GetComponent<MeshRenderer>().enabled = false;
            }

            if (hit.collider.gameObject == Waterfall2 && REC.activeSelf == true)
            {
                WaterfallCheck2.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    WaterfallCheck2.GetComponent<MeshRenderer>().enabled = false;
                    WaterfallPic.SetActive(true);
                    WaterfallPicPro.SetActive(true);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                }
            }
            else if (hit.collider.gameObject == Waterfall2 && REC.activeSelf == false)
            {
                WaterfallCheck2.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    WaterfallCheck2.GetComponent<MeshRenderer>().enabled = false;
                    wf_s.SetActive(true);
                    wf_sPro.SetActive(true);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                }
            }
            else
            {
                WaterfallCheck2.GetComponent<MeshRenderer>().enabled = false;
            }

            //Gear
            if (hit.collider.gameObject == Gear_sCheck)
            {
                Gear_sCheck.GetComponent<MeshRenderer>().enabled = true;
                if(Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    Gear_sCheck.GetComponent <MeshRenderer>().enabled = false;
                    Gear_sPic.SetActive(true);
                    Gear_sPicPro.SetActive(true);
                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                Gear_sCheck.GetComponent<MeshRenderer>().enabled = false;
            }

            if (hit.collider.gameObject == gearActive1 && Gear_S1.activeSelf == true)
            {
                gearCheck1.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    gearCheck1.GetComponent<MeshRenderer>().enabled = false;
                    Gear_sPic.SetActive(true);
                    Gear_sPicPro.SetActive(true);

                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                gearCheck1.GetComponent<MeshRenderer>().enabled = false;
            }

            //if (hit.collider.gameObject == gearActive1 && REC.activeSelf == true && Gear_D1.activeSelf == true)
            //{
            //    gearCheck1D.GetComponent<MeshRenderer>().enabled = true;
            //    if (Input.GetMouseButtonDown(0))
            //    {
            //        gearCheck1D.GetComponent<MeshRenderer>().enabled = false;
            //        Gear_dPic.SetActive(true);
            //        Gear_dPicPro.SetActive(true);

            //        Gear_sPic.SetActive(false);
            //        Gear_sPicPro.SetActive(false);

            //        WaterfallPic.SetActive(false);
            //        WaterfallPicPro.SetActive(false);
            //        CubePic.SetActive(false);
            //        CubePicPro.SetActive(false);
            //        DoorPic.SetActive(false);
            //        DoorPicPro.SetActive(false);
            //        BridgePic.SetActive(false);
            //        BridgePicPro.SetActive(false);
            //        sunPic.SetActive(false);
            //        sunPicPro.SetActive(false);
            //    }
            //}
            //else
            //{
            //    gearCheck1D.GetComponent<MeshRenderer>().enabled = false;
            //}

            if (hit.collider.gameObject == gearActive2 && Gear_D2.activeSelf == true)
            {
                gearCheck2.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    gearCheck2.GetComponent<MeshRenderer>().enabled = false;
                    Gear_sPic.SetActive(true);
                    Gear_sPicPro.SetActive(true);

                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                gearCheck2.GetComponent<MeshRenderer>().enabled = false;
            }

            if (hit.collider.gameObject == gearActive2 && REC.activeSelf == true && Gear_D2.activeSelf == true)
            {
                gearCheck2D.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    gearCheck2D.GetComponent<MeshRenderer>().enabled = false;
                    Gear_dPic.SetActive(true);
                    Gear_dPicPro.SetActive(true);

                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                gearCheck2D.GetComponent<MeshRenderer>().enabled = false;
            }

            if (hit.collider.gameObject == gearActive3 && Gear_S3.activeSelf == true)
            {
                gearCheck3.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    gearCheck3.GetComponent<MeshRenderer>().enabled = false;
                    Gear_sPic.SetActive(true);
                    Gear_sPicPro.SetActive(true);

                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                gearCheck3.GetComponent<MeshRenderer>().enabled = false;
            }

            if (hit.collider.gameObject == gearActive3 && REC.activeSelf == true && Gear_D3.activeSelf == true)
            {
                gearCheck3D.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    gearCheck3D.GetComponent<MeshRenderer>().enabled = false;
                    Gear_dPic.SetActive(true);
                    Gear_dPicPro.SetActive(true);

                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                gearCheck3D.GetComponent<MeshRenderer>().enabled = false;
            }

            //sun
            if (hit.collider.gameObject == Sun)
            {
                if(Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    sunPic.SetActive(true);
                    sunPicPro.SetActive(true);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);

                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);

                    colorDoorPic.SetActive(false);
                    colorDoorPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }

            //color_room
            if(hit.collider.gameObject == colorDoorBox)
            {
                colorDoorCapCheck.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    catchSound.Play();
                    colorDoorCapCheck.GetComponent<MeshRenderer>().enabled = false;
                    colorDoorPic.SetActive(true);
                    colorDoorPicPro.SetActive (true);

                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);

                    WaterfallPic.SetActive(false);
                    WaterfallPicPro.SetActive(false);
                    CubePic.SetActive(false);
                    CubePicPro.SetActive(false);
                    DoorPic.SetActive(false);
                    DoorPicPro.SetActive(false);
                    BridgePic.SetActive(false);
                    BridgePicPro.SetActive(false);
                    Gear_sPic.SetActive(false);
                    Gear_sPicPro.SetActive(false);

                    Gear_dPic.SetActive(false);
                    Gear_dPicPro.SetActive(false);
                    wf_s.SetActive(false);
                    wf_sPro.SetActive(false);
                }
            }
            else
            {
                colorDoorCapCheck.GetComponent<MeshRenderer>().enabled = false;
            }
        }
        else
        {
            DoorCapable11.GetComponent<MeshRenderer>().enabled = false;
            DoorCapable12.GetComponent<MeshRenderer>().enabled = false;
            DoorCapable13.GetComponent<MeshRenderer>().enabled = false;
            DoorCapable14.GetComponent<MeshRenderer>().enabled = false;
            DoorCapable15.GetComponent<MeshRenderer>().enabled = false;
            DoorCapable16.GetComponent<MeshRenderer>().enabled = false;
            DoorCapable21.GetComponent<MeshRenderer>().enabled = false;
            DoorCapable22.GetComponent<MeshRenderer>().enabled = false;
            DoorCapable23.GetComponent<MeshRenderer>().enabled = false;
            Gear_sCheck.GetComponent<MeshRenderer>().enabled = false;
            DoorBox1.SetActive(false);
            DoorBox2.SetActive(false);
            DoorBox3.SetActive(false);
            BlockChecked1.SetActive(false);
            BlockChecked2.SetActive(false);
            BlockChecked3.SetActive(false);
            CubeChecked1.SetActive(false);
            CubeChecked2.SetActive(false);
            CubeChecked3.SetActive(false);
            CubeChecked4.SetActive(false);
            CubeChecked5.SetActive(false);
            WaterfallCheck1.GetComponent<MeshRenderer>().enabled = false;
            WaterfallCheck2.GetComponent<MeshRenderer>().enabled = false;

            gearCheck1.GetComponent<MeshRenderer>().enabled = false;
            gearCheck2.GetComponent<MeshRenderer>().enabled = false;
            gearCheck3.GetComponent<MeshRenderer>().enabled = false;
            gearCheck1D.GetComponent<MeshRenderer>().enabled = false;
            gearCheck2D.GetComponent<MeshRenderer>().enabled = false;
            gearCheck3D.GetComponent<MeshRenderer>().enabled = false;

            colorDoorCapCheck.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    private void OnDisable() 
    {
        DoorCapable11.GetComponent<MeshRenderer>().enabled = false;
        DoorCapable12.GetComponent<MeshRenderer>().enabled = false;
        DoorCapable13.GetComponent<MeshRenderer>().enabled = false;
        DoorCapable14.GetComponent<MeshRenderer>().enabled = false;
        DoorCapable15.GetComponent<MeshRenderer>().enabled = false;
        DoorCapable16.GetComponent<MeshRenderer>().enabled = false;
        DoorCapable21.GetComponent<MeshRenderer>().enabled = false;
        DoorCapable22.GetComponent<MeshRenderer>().enabled = false;
        DoorCapable23.GetComponent<MeshRenderer>().enabled = false;
        DoorBox1.SetActive(false);
        DoorBox2.SetActive(false);
        DoorBox3.SetActive(false);
        BlockChecked1.SetActive(false);
        BlockChecked2.SetActive(false);
        BlockChecked3.SetActive(false);
        WaterfallCheck1.GetComponent<MeshRenderer>().enabled = false;
        WaterfallCheck2.GetComponent<MeshRenderer>().enabled = false;
        Gear_sCheck.GetComponent<MeshRenderer>().enabled = false;

        gearCheck1.GetComponent<MeshRenderer>().enabled = false;
        gearCheck2.GetComponent<MeshRenderer>().enabled = false;
        gearCheck3.GetComponent<MeshRenderer>().enabled = false;
        gearCheck1D.GetComponent<MeshRenderer>().enabled = false;
        gearCheck2D.GetComponent<MeshRenderer>().enabled = false;
        gearCheck3D.GetComponent<MeshRenderer>().enabled = false;

        colorDoorCapCheck.GetComponent<MeshRenderer>().enabled = false;

    }
}