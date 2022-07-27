using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamUI : MonoBehaviour
{
    [SerializeField] GameObject testPlayer;
    [SerializeField] GameObject CamforPlayer;
    [SerializeField] GameObject qL;
    [SerializeField] GameObject rL;
    [SerializeField] GameObject mouseL;
    [SerializeField] GameObject mouseR;
    [SerializeField] GameObject Video;
    [SerializeField] GameObject UI;
    [SerializeField] GameObject Catch;
    [SerializeField] GameObject Project;
    [SerializeField] GameObject PHO;
    [SerializeField] GameObject REC;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(CamforPlayer.activeSelf == true)
            {
                CamforPlayer.SetActive(false);
                Video.SetActive(false);
                UI.SetActive(true);
                Catch.SetActive(false);
                PHO.SetActive(false);
                Project.SetActive(true);
                testPlayer.GetComponent<CaptureThings>().enabled = true;
            }
            else if(CamforPlayer.activeSelf == false)
            {
                CamforPlayer.SetActive(true);
                UI.SetActive(false);
                testPlayer.GetComponent<CaptureThings>().enabled = false;
                testPlayer.GetComponent<PlaceDoors>().enabled = false;
                testPlayer.GetComponent<PlaceBridge>().enabled = false;
                testPlayer.GetComponent<PlaceBox>().enabled = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && UI.gameObject.activeSelf == true)
        {
            if(Catch.activeSelf == false)
            {
                Catch.SetActive(true);
                PHO.SetActive(true);
                REC.SetActive(true);
                Project.SetActive(false);
                testPlayer.GetComponent<CaptureThings>().enabled = false;
                testPlayer.GetComponent<PlaceDoors>().enabled = true;
                testPlayer.GetComponent<PlaceBridge>().enabled = true;
                testPlayer.GetComponent<PlaceBox>().enabled = true;
            }
            else
            {
                Catch.SetActive(false);
                PHO.SetActive(false);
                REC.SetActive(true);
                Project.SetActive(true);
                testPlayer.GetComponent<CaptureThings>().enabled = true;
                testPlayer.GetComponent<PlaceDoors>().enabled = false;
                testPlayer.GetComponent<PlaceBridge>().enabled = false;
                testPlayer.GetComponent<PlaceBox>().enabled = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q) && UI.gameObject.activeSelf == true)
        {
            if(Catch.activeSelf == false)
            {
                if(Video.activeSelf == false)
                {
                    PHO.SetActive(true);
                    REC.SetActive(false);
                    Video.SetActive(true);
                }
                else
                {
                    PHO.SetActive(false);
                    REC.SetActive(true);
                    Video.SetActive(false);
                }  
            }
        }
    }

}
