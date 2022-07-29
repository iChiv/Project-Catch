using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foucs : MonoBehaviour
{
    GameObject CamForPlayer;
    GameObject MainCam;
    GameObject Player;
    GameObject Canvas;
    GameObject CamUI;
    GameObject Cam;
    GameObject Project;
    GameObject Shoot;
    GameObject Video;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        MainCam = Player.transform.GetChild(0).gameObject;
        CamForPlayer = MainCam.transform.GetChild(0).gameObject;
        Canvas = GameObject.Find("Canvas");
        CamUI = Canvas.transform.GetChild(0).gameObject;
        Cam = CamUI.transform.GetChild(3).gameObject;
        Project = CamUI.transform.GetChild(1).gameObject;
        Shoot = CamUI.transform.GetChild(0).gameObject;
        Video = CamUI.transform.GetChild(2).gameObject;
    }

    // Update is called once per frame
    [System.Obsolete]
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (CamForPlayer.gameObject.activeSelf == true)
            {
                CamForPlayer.gameObject.SetActive(false);
                Cam.gameObject.SetActive(true);
                Shoot.gameObject.SetActive(true);
                Player.GetComponent<CaptureThings>().enabled = true;
            }
            else
            {
                CamForPlayer.gameObject.SetActive(true);
                Cam.gameObject.SetActive(false);
                Shoot.gameObject.SetActive(false);
                Project.gameObject.SetActive(false);
                Video.gameObject.SetActive(false);
                Player.GetComponent<CaptureThings>().enabled = false;
                Player.GetComponent<PlaceDoors>().enabled = false;
                Player.GetComponent<PlaceBridge>().enabled = false;
                Player.GetComponent<PlaceBox>().enabled = false;
                Player.GetComponent<PlaceWaterfall>().enabled = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && Cam.gameObject.activeSelf == true)
        {
            if (Shoot.gameObject.activeSelf == true)
            {
                Shoot.gameObject.SetActive(false);
                Project.gameObject.SetActive(true);
                Player.GetComponent<CaptureThings>().enabled = false;
                Player.GetComponent<PlaceDoors>().enabled = true;
                Player.GetComponent<PlaceBridge>().enabled = true;
                Player.GetComponent<PlaceBox>().enabled = true;
                Player.GetComponent<PlaceWaterfall>().enabled = true;
            }
            else
            {
                Shoot.gameObject.SetActive(true);
                Project.gameObject.SetActive(false);
                Player.GetComponent<CaptureThings>().enabled = true;
                Player.GetComponent<PlaceDoors>().enabled = false;
                Player.GetComponent<PlaceBridge>().enabled = false;
                Player.GetComponent<PlaceBox>().enabled = false;
                Player.GetComponent<PlaceWaterfall>().enabled = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Shoot.gameObject.activeSelf == true)
            {
                if (Video.gameObject.activeSelf == false)
                {
                    Video.gameObject.SetActive(true);
                }
                else
                {
                    Video.gameObject.SetActive(false);
                }
            }

        }


    }
}
