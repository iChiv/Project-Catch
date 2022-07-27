using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureThings : MonoBehaviour
{
    public GameObject mainCam;

    RaycastHit hit;
    public GameObject DoorOpen2;
    public GameObject DoorOpen3;
    public GameObject DoorPic;
    public GameObject DoorCapable11;
    public GameObject DoorCapable12;
    public GameObject DoorCapable13;
    public GameObject DoorCapable14;
    public GameObject DoorCapable15;
    public GameObject DoorCapable16;

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
                if (Input.GetMouseButtonDown(0))
                {
                    DoorPic.SetActive(true);
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
            }
            if (hit.collider.gameObject == DoorOpen3)
            {
                DoorCapable21.GetComponent<MeshRenderer>().enabled = true;
                DoorCapable22.GetComponent<MeshRenderer>().enabled = true;
                DoorCapable23.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    DoorPic.SetActive(true);
                }
            }
            else
            {
                DoorCapable21.GetComponent<MeshRenderer>().enabled = false;
                DoorCapable22.GetComponent<MeshRenderer>().enabled = false;
                DoorCapable23.GetComponent<MeshRenderer>().enabled = false;
            }
            //cliff
            if (hit.collider.gameObject == Block1)
            {
                BlockChecked1.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    BridgePic.SetActive(true);
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
                }
            }
            else
            {
                CubeChecked5.SetActive(false);
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
            BlockChecked1.SetActive(false);
            BlockChecked2.SetActive(false);
            BlockChecked3.SetActive(false);
            CubeChecked1.SetActive(false);
            CubeChecked2.SetActive(false);
            CubeChecked3.SetActive(false);
            CubeChecked4.SetActive(false);
            CubeChecked5.SetActive(false);
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
        BlockChecked1.SetActive(false);
        BlockChecked2.SetActive(false);
        BlockChecked3.SetActive(false);

    }
}