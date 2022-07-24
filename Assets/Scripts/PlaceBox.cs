using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBox : MonoBehaviour
{
    public GameObject mainCam;
    RaycastHit hit;

    public GameObject cubeCheck1;
    public GameObject cubeCheck2;
    public GameObject cubeCheck3;

    public GameObject cubeReady1;
    public GameObject cubeReady2;
    public GameObject cubeReady3;

    public GameObject cubeOK1;
    public GameObject cubeOK2;
    public GameObject cubeOK3;

    public GameObject CubePicInShoot;
    public GameObject CubePicInProjection;
    void Update()
    {
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit) && CubePicInProjection.activeSelf == true)
        {
            if(hit.collider.gameObject == cubeCheck1)
            {
                cubeReady1.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    cubeOK1.SetActive(true);
                    cubeReady1.SetActive(false);
                    CubePicInShoot.SetActive(false);
                    CubePicInProjection.SetActive(false);
                }
            }
            else
            {
                cubeReady1.SetActive(false);
            }
            if (hit.collider.gameObject == cubeCheck2)
            {
                cubeReady2.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    cubeOK2.SetActive(true);
                    cubeReady2.SetActive(false);
                    cubeReady2.GetComponent<MeshRenderer>().enabled = false;
                    CubePicInShoot.SetActive(false);
                    CubePicInProjection.SetActive(false);
                }
            }
            else
            {
                cubeReady2.SetActive(false);
            }
            if (hit.collider.gameObject == cubeCheck3)
            {
                cubeReady3.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    cubeOK3.SetActive(true);
                    cubeReady3.SetActive(false);
                    CubePicInShoot.SetActive(false);
                    CubePicInProjection.SetActive(false);
                }
            }
            else
            {
                cubeReady3.SetActive(false);
            }
        }
        else
        {
            cubeReady1.SetActive(false);
            cubeReady2.SetActive(false);
            cubeReady3.SetActive(false);
        } 
    }
}
