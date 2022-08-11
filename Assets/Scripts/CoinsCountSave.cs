using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCountSave : MonoBehaviour
{
    public int count;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.Find("CoinNum").GetComponent<CoinCount>().coinsNum;
    }
}
