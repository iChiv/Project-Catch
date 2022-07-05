using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCamera : MonoBehaviour
{
    GameObject MainCam;
    GameObject Player;
    GameObject CamForPlayer;
    GameObject Canvas;
    GameObject Check;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        MainCam = GameObject.Find("Main Camera");
        Player = MainCam.transform.parent.gameObject;
        CamForPlayer = MainCam.transform.GetChild(0).gameObject;
        Canvas = GameObject.Find("Canvas");
        Check = Canvas.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit , 10))
        {
            if(hit.collider.tag == "camObj")
            {
                Check.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    CamForPlayer.gameObject.SetActive(true);
                    Check.gameObject.SetActive(false);
                    Player.GetComponent<Foucs>().enabled = true;
                }
            }
        else
        {
            Check.gameObject.SetActive(false);
        }
        }
    }
}
