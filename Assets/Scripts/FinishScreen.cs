using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using DG.Tweening;

public class FinishScreen : MonoBehaviour
{
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject player;
    public GameObject mc;

    public GameObject coinCount1;
    public GameObject coinCount2;
    public GameObject coinCount3;
    public GameObject coinBouns;

    public AudioSource confirmSound;

    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        coins = GameObject.Find("CoinCountSave").GetComponent<CoinsCountSave>().count;
        //GameObject.Find("CoinCountSave").SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        mainCam.GetComponent<CameraLock>().enabled = false;
        player.GetComponent<PlayerMover>().enabled = false;
        mc.GetComponent<FrameRateLock>().enabled = false;

        coinCount1.GetComponent<DOTweenAnimation>().DOPause();
        coinCount2.GetComponent<DOTweenAnimation>().DOPause();
        coinCount3.GetComponent<DOTweenAnimation>().DOPause();
        coinBouns.GetComponent<DOTweenAnimation>().DOPause();
    }
    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if(coins == 2)
        {
            coinCount1.GetComponent<DOTweenAnimation>().DOPlay();
        }
        else if(coins == 1)
        {
            coinCount1.GetComponent<DOTweenAnimation>().DOPlay();
            coinCount2.GetComponent<DOTweenAnimation>().DOPlay();
        }
        else if(coins == 0)
        {
            coinCount1.GetComponent<DOTweenAnimation>().DOPlay();
            coinCount2.GetComponent<DOTweenAnimation>().DOPlay();
            coinCount3.GetComponent<DOTweenAnimation>().DOPlay();
            coinBouns.GetComponent<DOTweenAnimation>().DOPlay();
        }
        else
        {
            coinCount1.SetActive(false);
            coinCount2.SetActive(false);
            coinCount3.SetActive(false);
        }
    }

    public void ReStartGame()
    {
        confirmSound.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level_01");
    }

    public void exitGame()
    {
        //confirmSound.Play();
        Application.Quit();
    }

    public void getBouns()
    {
        //confirmSound.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene("WhiteBox");
    }
}
