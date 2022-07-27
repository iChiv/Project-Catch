using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foucs : MonoBehaviour
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

    void update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(CamforPlayer.activeSelf == true)
            {
                CamforPlayer.SetActive(false);
                UI.SetActive(true);
                testPlayer.GetComponent<CaptureThings>().enabled = true;
            }
            else if(CamforPlayer.activeSelf == false)
            {
                CamforPlayer.SetActive(true);
                UI.SetActive(false);
                testPlayer.GetComponent<CaptureThings>().enabled = false;
            }
        }
    }

}
