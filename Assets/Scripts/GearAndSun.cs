using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GearAndSun : MonoBehaviour
{
    public GameObject gear1S;
    public GameObject gear1D;
    public GameObject gear1Dxxx;
    public GameObject gear2D;
    public GameObject gear3S;
    public GameObject gear3D;

    public GameObject gear01;
    public GameObject gear02;
    public GameObject gear03;
    public GameObject gear04;

    public GameObject gear1core;
    public GameObject gear3core;

    public GameObject sunLight;

    public GameObject indicator_machine_off;
    public GameObject indicator_machine_on;

    public GameObject indicator_both_01_off;
    public GameObject indicator_both_01_on;
    public GameObject indicator_both_02_off;
    public GameObject indicator_both_02_on;

    public GameObject elevatorP;
    public GameObject elevator;

    private void Start()
    {
        gear1core.GetComponent<DOTweenAnimation>().DOPause();
        gear3core.GetComponent<DOTweenAnimation>().DOPause();
        Vector3 gear3origin = gear3S.transform.position;
        Vector3 gear1origin = gear1S.transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        if(gear2D.activeSelf == true)
        {
            gear1core.GetComponent<DOTweenAnimation>().DOPlay();
            gear3core.GetComponent<DOTweenAnimation>().DOPlay();
            gear1core.GetComponent<BoxCollider>().enabled = true;
            gear3core.GetComponent<BoxCollider>().enabled = true;
        }

        if(gear1Dxxx.activeSelf == true)
        {
            gear1Dxxx.GetComponent<DOTweenPath>().DORestart(true);
            Invoke("destoryXXX", 5f);
        }

        if(gear3S.activeSelf == true)
        {
            gear3S.GetComponent<DOTweenPath>().DORestart(true);
            Invoke("destory3S", 5f);
        }

        if(gear3D.activeSelf == true)
        {
            gear04.GetComponent<gear_rotation>().enabled = true;
            gear03.GetComponent<gear_rotation>().enabled = true;
        }

        if(gear1S.activeSelf == true)
        {
            if(gear3D.activeSelf == true)
            {
                gear1S.GetComponent<gear_rotation>().enabled = true;
                gear01.GetComponent<gear_rotation>().enabled = true;
                gear02.GetComponent<gear_rotation>().enabled = true;
                indicator_machine_off.SetActive(false);
                indicator_machine_on.SetActive(true);

                indicator_both_01_off.SetActive(false);
                indicator_both_01_on.SetActive(true);
            }
            else
            {
                Invoke("brokengear", 2f);
                Invoke("destoryXXX", 5f);
            }
        }

        if (sunLight.activeSelf == true)
        {
            indicator_both_02_off.SetActive(false);
            indicator_both_02_on.SetActive(true);
        }

        if(indicator_both_01_on.activeSelf == true && indicator_both_02_on.activeSelf == true)
        {
            elevatorP.GetComponent<Elevator>().enabled = true;
        }

        
    }

    private void brokengear()
    {
        gear1S.GetComponent<DOTweenPath>().DOPlay();
    }

    private void destoryXXX()
    {
        gear1Dxxx.SetActive(false);
    }

    private void destory3S()
    {
        gear3S.SetActive(false);
    }
}
