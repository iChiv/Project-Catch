using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinCount : MonoBehaviour
{
    public GameObject coinCount;
    public GameObject count0;
    public GameObject count1;
    public GameObject count2;
    public GameObject count3;

    public int coinsNum;
    public GameObject[] m_coins;
    // Start is called before the first frame update
    void Start()
    {
        m_coins = GameObject.FindGameObjectsWithTag("coin");
    }

    // Update is called once per frame
    void Update()
    {
        
        m_coins = GameObject.FindGameObjectsWithTag("coin");
        coinsNum = m_coins.Length;
        //Debug.Log(m_coins.Length);
        if (m_coins.Length == 2)
        {
            coinCount.GetComponent<DOTweenAnimation>().DOPlay();
            count0.SetActive(false);
            count1.SetActive(true);
        }
        else if (m_coins.Length == 1)
        {
            count1.SetActive(false);
            count2.SetActive(true);
        }
        else if(m_coins.Length == 0)
        {
            count2.SetActive(false);
            count3.SetActive(true);
        }
    }
}
