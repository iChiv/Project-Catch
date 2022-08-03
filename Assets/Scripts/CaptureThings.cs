using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureThings : MonoBehaviour
{
    public GameObject mainCam;
    [SerializeField] GameObject REC;

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

    //Gear
    [SerializeField] GameObject Gear_s;
    [SerializeField] GameObject Gear_sCheck;

    [SerializeField] GameObject Gear_sPic;
    [SerializeField] GameObject Gear_sPicPro;

    //SUN
    [SerializeField] GameObject Sun;
    [SerializeField] GameObject sunPic;
    [SerializeField] GameObject sunPicPro;
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
                    WaterfallCheck1.GetComponent<MeshRenderer>().enabled = false;
                    WaterfallPic.SetActive(true);
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
                    WaterfallCheck2.GetComponent<MeshRenderer>().enabled = false;
                    WaterfallPic.SetActive(true);
                    WaterfallPicPro.SetActive(true);
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
                    Gear_sCheck.GetComponent <MeshRenderer>().enabled = false;
                    Gear_sPic.SetActive(true);
                    Gear_sPicPro.SetActive(true);

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
                }
            }
            else
            {
                Gear_sCheck.GetComponent<MeshRenderer>().enabled = false;
            }

            //sun
            if(hit.collider.gameObject == Sun)
            {
                if(Input.GetMouseButtonDown(0))
                {
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

                }
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

    }
}