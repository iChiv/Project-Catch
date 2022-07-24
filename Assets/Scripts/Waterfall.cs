using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Waterfall : MonoBehaviour
{
    public GameObject BOX1;
    public GameObject BOX2;
    public GameObject BOX3;

    public GameObject indicator1;
    public GameObject indicator2;
    public GameObject indicator3;
    public GameObject indicatorO1;
    public GameObject indicatorO2;
    public GameObject indicatorO3;

    public GameObject WaterfallControl;

    private void Start()
    {
        WaterfallControl.GetComponent<DOTweenAnimation>().DOPause();
    }
    // Update is called once per frame
    void Update()
    {
        if(BOX1.activeSelf == true)
        {
            indicator1.SetActive(true);
            indicatorO1.SetActive(false);
        }
        if (BOX2.activeSelf == true)
        {
            indicator2.SetActive(true);
            indicatorO2.SetActive(false);
        }
        if (BOX3.activeSelf == true)
        {
            indicator3.SetActive(true);
            indicatorO3.SetActive(false);
        }
        if (indicator1.activeSelf == true && indicator2.activeSelf == true && indicator3)
        {
            if( indicator3.activeSelf == true )
            {
                WaterfallControl.GetComponent<DOTweenAnimation>().DOPlay();
            }
        }
    }
}
