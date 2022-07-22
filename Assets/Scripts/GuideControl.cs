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
    public GameObject ShootUI;
    public GameObject ProjectUI;
    public GameObject Video;
    public GameObject PressRight;
    public GameObject PressLeft1;
    public GameObject PressLeft2;
    public GameObject PressR;
    public GameObject PressQ;

    public GameObject DoorProjection1;
    public GameObject DoorProjection2;
    public GameObject DoorOpen1;
    public GameObject DoorOpen2;

    public GameObject GuideLight1;
    public GameObject GuideLight2;
    public GameObject GuideLight3;
    // Start is called before the first frame update
    void Start()
    {
        GuideLight1.GetComponent<DOTweenAnimation>().DOPause();
        GuideLight2.GetComponent<DOTweenAnimation>().DOPause();
        GuideLight3.GetComponent<DOTweenAnimation>().DOPause();
    }
    // Update is called once per frame
    void Update()
    {
        //right button
        if(!guide1 && cameraObj.activeSelf == true)
        {
            PressRight.SetActive(true);
            if (Input.GetMouseButtonDown(1))
            {
                PressRight.SetActive(false);
                guide1 = true;
            }
        }
        else
        {
            PressRight.SetActive(false);
        }


        //R
        if (!guide2 && ShootUI.activeSelf == true)
        {
            PressR.SetActive(true);
            GuideLight2.GetComponent<DOTweenAnimation>().DOPlay();
            if (Input.GetKeyDown(KeyCode.R))
            {
                PressR.SetActive(false);
                guide2 = true;
            }
        }
        else
        {
            PressR.SetActive(false);
        }

        //L1
        if (!guide3)
        {
            if(DoorProjection1.activeSelf == true || DoorProjection2.activeSelf == true)
            {
                PressLeft1.SetActive(true);
                GuideLight3.GetComponent<DOTweenAnimation>().DOPlay();
                if (Input.GetMouseButtonDown(0))
                {
                    PressLeft1.SetActive(false);
                    guide3 = false;
                }
            }
            else
            {
                PressLeft1.SetActive(false);
            }
        }
        else
        {
            PressLeft1.SetActive(false);
        }

        if (!guide4)
        {
            if (DoorOpen1.activeSelf == true || DoorOpen2.activeSelf == true)
            {
                PressLeft2.SetActive(true);
                GuideLight1.GetComponent<DOTweenAnimation>().DOPlay();
                if (Input.GetMouseButtonDown(0))
                {
                    PressLeft2.SetActive(false);
                    guide4 = false;
                }
            }
            else
            {
                PressLeft2.SetActive(false);
            }
        }
        else
        {
            PressLeft2.SetActive(false);
        }

    }
}
