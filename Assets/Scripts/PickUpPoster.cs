using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoster : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject poster;
    [SerializeField] GameObject posterUI;
    int layerMask = 1 << 6;

    // Update is called once per frame
    void Update()
    {
        if(posterUI.activeSelf == false)
        {
            if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit,50,layerMask))
            {
                //Debug.Log(hit.collider.name);
                if (hit.collider.gameObject == poster)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        posterUI.SetActive(true);
                        mainCam.GetComponent<CameraLock>().enabled = false;
                    }
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                posterUI.SetActive(false);
                mainCam.GetComponent<CameraLock>().enabled = true;
            }
        }
    }
}
