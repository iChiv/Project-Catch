using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSunLight : MonoBehaviour
{
    public AudioSource projectSound;
    public GameObject mainCam;
    RaycastHit hit;
    int layerMask = 1 << 6;
    [SerializeField] GameObject sunPic;
    [SerializeField] GameObject sunPicPro;

    [SerializeField] GameObject lightCheck;
    [SerializeField] GameObject Light;
    [SerializeField] GameObject Sun1;
    [SerializeField] GameObject elevatorCheck;

    // Update is called once per frame
    void Update()
    {
        if(sunPic.activeSelf == true)
        {
            elevatorCheck.SetActive(true);
        }
        else
        {
            elevatorCheck.SetActive(false);
        }

        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 50, layerMask) && sunPic.activeSelf == true)
        {
            if(hit.collider.gameObject == lightCheck)
            {
                if(Input.GetMouseButtonDown(0))
                {
                    Sun1.SetActive(true);
                    projectSound.Play();
                    Light.SetActive(true);
                    sunPic.SetActive(false);
                    sunPicPro.SetActive(false);
                }
            }
        }
    }
}
