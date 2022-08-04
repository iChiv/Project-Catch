using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSunLight : MonoBehaviour
{
    public GameObject mainCam;
    RaycastHit hit;
    int layerMask = 1 << 6;
    [SerializeField] GameObject sunPic;
    [SerializeField] GameObject sunPicPro;

    [SerializeField] GameObject lightCheck;
    [SerializeField] GameObject Light;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 50, layerMask) && sunPic.activeSelf == true)
        {
            if(hit.collider.gameObject == lightCheck)
            {
                if(Input.GetMouseButtonDown(0))
                {
                    Light.SetActive(true);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                }
            }
        }
    }
}
