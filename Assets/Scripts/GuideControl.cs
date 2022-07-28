using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GuideControl : MonoBehaviour
{
    private bool guide1 = false;
    private bool guide2 = false;
    private bool guide3 = false;
    private bool guide4 = false;
    //private bool guide5 = false;
    //private bool guide6 = false;

    public GameObject cameraObj;
    [SerializeField] GameObject CamUI;
    [SerializeField] GameObject DoorCheck;
    [SerializeField] GameObject DoorPic;

    public GameObject indicator1;
    public GameObject indicator2;
    public GameObject indicator3;

    public GameObject Video;
    public GameObject PressRight;
    public GameObject PressLeft;
    public GameObject PressR;
    public GameObject PressQ;

    // Start is called before the first frame update
    void Start()
    {
        PressLeft.GetComponent<DOTweenAnimation>().DOPause();
        PressR.GetComponent<DOTweenAnimation>().DOPause();
        PressQ.GetComponent<DOTweenAnimation>().DOPause();
    }
    // Update is called once per frame
    void Update()
    {
        //right button
        //if (!guide1 && cameraObj.activeSelf == true)
        //{
        //    PressRight.SetActive(true);
        //    if (Input.GetMouseButtonDown(1))
        //    {
        //        PressRight.SetActive(false);
        //        guide1 = true;
        //    }
        //}
        //else
        //{
        //    PressRight.SetActive(false);
        //}


        //L mouse
        if (!guide2 && CamUI.activeSelf == true)
        {
            if (DoorCheck.GetComponent<Renderer>().enabled == true)
            {
                PressLeft.GetComponent<DOTweenAnimation>().DOPlay();
                if (Input.GetMouseButtonDown(0))
                {
                    PressLeft.SetActive(false);
                    guide2 = true;
                }
            }
        }

        //R
        if(!guide3 && DoorPic.activeSelf == true)
        {
            PressR.GetComponent<DOTweenAnimation>().DOPlay();
            if(Input.GetKeyDown(KeyCode.R))
            {
                PressR.SetActive(false);
                guide3 = true;
            }
        }

        if(!guide4 && indicator3.activeSelf == true)
        {
            if (indicator1.activeSelf == true && indicator2.activeSelf == true )
            {
                PressQ.GetComponent<DOTweenAnimation>().DOPlay();
                if(Input.GetKeyDown(KeyCode.Q))
                {
                    PressQ.SetActive(false);
                    guide4 = true;
                }
            }
        }


    }
}
