using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
    [SerializeField] GameObject ProjObj;
    [SerializeField] GameObject Q_all;
    [SerializeField] GameObject REC_all;
    [SerializeField] GameObject PHO_all;

    public GameObject UI_c;

    private void Start()
    {
        Q_all.GetComponent<DOTweenAnimation>().DOPlay();
        UI.GetComponent<DOTweenAnimation>().DOPlay();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(CamforPlayer.activeSelf == true)
            {
                UI_c.GetComponent<UI_Control>().enabled = true;
                UI.GetComponent<DOTweenAnimation>().DORestart();
                Q_all.GetComponent<DOTweenAnimation>().DORestart();
                REC_all.GetComponent<DOTweenAnimation>().DORestart();
                PHO_all.GetComponent<DOTweenAnimation>().DORestart();
                CamforPlayer.SetActive(false);
                Video.SetActive(false);
                UI.SetActive(true);
                Catch.SetActive(false);
                PHO.SetActive(false);
                REC.SetActive(true);
                Project.SetActive(true);
                ProjObj.SetActive(false);
                testPlayer.GetComponent<CaptureThings>().enabled = true;
            }
            else if(CamforPlayer.activeSelf == false)
            {
                //Q_all.GetComponent<DOTweenAnimation>().DORestart();
                //REC_all.GetComponent<DOTweenAnimation>().DORestart();
                //PHO_all.GetComponent<DOTweenAnimation>().DORestart();
                //CamforPlayer.SetActive(true);
                UI_c.GetComponent<UI_Control>().enabled = false;
                UI.GetComponent<DOTweenAnimation>().DOPlayBackwards();
                Invoke("UIoff", 0.6f);
                CamforPlayer.SetActive(true);
                //UI.SetActive(false);
                testPlayer.GetComponent<CaptureThings>().enabled = false;
                testPlayer.GetComponent<PlaceDoors>().enabled = false;
                testPlayer.GetComponent<PlaceBridge>().enabled = false;
                testPlayer.GetComponent<PlaceBox>().enabled = false;
                testPlayer.GetComponent<PlaceWaterfall>().enabled = false;
                testPlayer.GetComponent<PlaceGears>().enabled = false;
                testPlayer.GetComponent<PlaceSunLight>().enabled = false;
                testPlayer.GetComponent<PlaceColorRoom>().enabled = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && UI.gameObject.activeSelf == true)
        {
            if(Catch.activeSelf == false)
            {
                Q_all.GetComponent<DOTweenAnimation>().DOPlayBackwards();
                REC_all.GetComponent<DOTweenAnimation>().DOPlayBackwards();
                PHO_all.GetComponent<DOTweenAnimation>().DOPlayBackwards();
                Catch.SetActive(true);
                PHO.SetActive(true);
                REC.SetActive(true);
                Project.SetActive(false);
                Video.SetActive(false);
                ProjObj.SetActive(true);
                testPlayer.GetComponent<CaptureThings>().enabled = false;
                testPlayer.GetComponent<PlaceDoors>().enabled = true;
                testPlayer.GetComponent<PlaceBridge>().enabled = true;
                testPlayer.GetComponent<PlaceBox>().enabled = true;
                testPlayer.GetComponent<PlaceWaterfall>().enabled = true;
                testPlayer.GetComponent<PlaceGears>().enabled = true;
                testPlayer.GetComponent<PlaceSunLight>().enabled = true;
                testPlayer.GetComponent<PlaceColorRoom>().enabled = true;
            }
            else
            {
                Q_all.GetComponent<DOTweenAnimation>().DORestart();
                REC_all.GetComponent<DOTweenAnimation>().DORestart();
                PHO_all.GetComponent<DOTweenAnimation>().DORestart();
                Catch.SetActive(false);
                PHO.SetActive(false);
                REC.SetActive(true);
                Project.SetActive(true);
                ProjObj.SetActive(false);
                testPlayer.GetComponent<CaptureThings>().enabled = true;
                testPlayer.GetComponent<PlaceDoors>().enabled = false;
                testPlayer.GetComponent<PlaceBridge>().enabled = false;
                testPlayer.GetComponent<PlaceBox>().enabled = false;
                testPlayer.GetComponent<PlaceWaterfall>().enabled = false;
                testPlayer.GetComponent<PlaceGears>().enabled = false;
                testPlayer.GetComponent<PlaceSunLight>().enabled = false;
                testPlayer.GetComponent<PlaceColorRoom>().enabled = false;
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

    private void UIoff()
    {
        UI.SetActive(false);
    }


}
