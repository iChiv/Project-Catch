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

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("TestPlayer");
        MainCam = Player.transform.GetChild(0).gameObject;
        CamForPlayer = MainCam.transform.GetChild(0).gameObject;
        Canvas = GameObject.Find("Canvas");
        CamUI = Canvas.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    [System.Obsolete]
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(CamForPlayer.gameObject.activeSelf == true)
            { 
             CamForPlayer.gameObject.SetActive(false);
             CamUI.gameObject.SetActive(true);
             Player.GetComponent<PlaceThings>().enabled = true;
            }
            else
            {
                CamForPlayer.gameObject.SetActive(true);
                CamUI.gameObject.SetActive(false);
            }
        }
    }
}
