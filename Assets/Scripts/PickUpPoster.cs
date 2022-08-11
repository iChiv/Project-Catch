using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoster : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject player;
    [SerializeField] GameObject poster;
    [SerializeField] GameObject posterUI;
    int layerMask = 1 << 6;

    public GameObject mc;

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
                        player.GetComponent<PlayerMover>().enabled = false;
                        mc.GetComponent<FrameRateLock>().enabled = false;
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
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
                player.GetComponent<PlayerMover>().enabled = true;
                mc.GetComponent<FrameRateLock>().enabled = true;
            }
        }
    }
}
