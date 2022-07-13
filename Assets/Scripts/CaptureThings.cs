using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureThings : MonoBehaviour
{
    public GameObject mainCam;

    RaycastHit hit;
    public GameObject DoorOpen2;
    public GameObject DoorOpen3;
    public GameObject DoorPicInShoot;
    public GameObject DoorPicInProjection;
    public GameObject DoorCapable;
    public GameObject DoorCapable2;

    //cliff
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject BlockChecked1;
    public GameObject BlockChecked2;
    public GameObject BlockChecked3;

    public GameObject BridgePicInShoot;
    public GameObject BridgePicInProjection;
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

    public GameObject CubePicInShoot;
    public GameObject CubePicInProjection;
    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit,5000,layerMask))
        {
            //Debug.DrawRay(transform.position, transform.forward, Color.green);
            //Debug.Log(hit.collider.name);
            if (hit.collider.gameObject == DoorOpen2)
            {
                DoorCapable.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    DoorPicInShoot.SetActive(true);
                    DoorPicInProjection.SetActive(true);
                }
            }
            if (hit.collider.gameObject == DoorOpen3)
            {
                DoorCapable2.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    DoorPicInShoot.SetActive(true);
                    DoorPicInProjection.SetActive(true);
                }
            }   
            //cliff
            if (hit.collider.gameObject == Block1)
            {
                BlockChecked1.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    BridgePicInShoot.SetActive(true);
                    BridgePicInProjection.SetActive(true);
                }
            }
            if (hit.collider.gameObject == Block2)
            {
                BlockChecked2.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    BridgePicInShoot.SetActive(true);
                    BridgePicInProjection.SetActive(true);
                }
            }
            if (hit.collider.gameObject == Block3)
            {
                BlockChecked3.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    BridgePicInShoot.SetActive(true);
                    BridgePicInProjection.SetActive(true);
                }
            }
            if(hit.collider.gameObject == Cube1)
            {
                CubeChecked1.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    CubePicInShoot.SetActive(true);
                    CubePicInProjection.SetActive(true);
                }
            }
            if (hit.collider.gameObject == Cube2)
            {
                CubeChecked2.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    CubePicInShoot.SetActive(true);
                    CubePicInProjection.SetActive(true);
                }
            }
            if (hit.collider.gameObject == Cube3)
            {
                CubeChecked3.SetActive(true);
                if (Input.GetMouseButtonDown(0) && CubeOK1.activeSelf == true)
                {
                    CubePicInShoot.SetActive(true);
                    CubePicInProjection.SetActive(true);
                }
            }
            if (hit.collider.gameObject == Cube4)
            {
                CubeChecked4.SetActive(true);
                if (Input.GetMouseButtonDown(0) && CubeOK2.activeSelf == true)
                {
                    CubePicInShoot.SetActive(true);
                    CubePicInProjection.SetActive(true);
                }
            }
            if (hit.collider.gameObject == Cube5 )
            {
                CubeChecked5.SetActive(true);
                if (Input.GetMouseButtonDown(0) && CubeOK3.activeSelf == true)
                {
                    CubePicInShoot.SetActive(true);
                    CubePicInProjection.SetActive(true);
                }
            }
        }
        else
        {
            DoorCapable.SetActive(false);
            DoorCapable2.SetActive(false);
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
        DoorCapable.SetActive(false);
        DoorCapable2.SetActive(false);
        BlockChecked1.SetActive(false);
        BlockChecked2.SetActive(false);
        BlockChecked3.SetActive(false);

    }
}