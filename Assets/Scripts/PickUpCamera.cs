using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCamera : MonoBehaviour
{
    GameObject MainCam;
    GameObject Player;
    GameObject CamForPlayer;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        MainCam = GameObject.Find("Main Camera");
        Player = MainCam.transform.parent.gameObject;
        CamForPlayer = Player.transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
            {
                if(hit.collider.tag == "camObj")
                {
                    hit.collider.gameObject.SetActive(false);
                    CamForPlayer.gameObject.SetActive(true);
                }
            }
        }

    }
}
