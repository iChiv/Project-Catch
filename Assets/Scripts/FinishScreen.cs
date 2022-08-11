using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class FinishScreen : MonoBehaviour
{
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject player;
    public GameObject mc;

    public GameObject coinCount1;
    public GameObject coinCount2;
    public GameObject coinCount3;

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
    }
    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if(coins == 2)
        {
            coinCount1.SetActive(true);
        }
        else if(coins == 1)
        {
            coinCount1.SetActive(true);
            coinCount2.SetActive(true);
        }
        else if(coins == 0)
        {
            coinCount1.SetActive(true);
            coinCount2.SetActive(true);
            coinCount3.SetActive(true);
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
        SceneManager.LoadScene("Level_01");
    }

    public void exitGame()
    {
        confirmSound.Play();
        Application.Quit();
    }
}
