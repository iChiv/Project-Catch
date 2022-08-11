using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            audioSource.Play();
            startGame();
        }
    }

    public void startGame()
    {
        SceneManager.LoadScene("Level_01");
    }
}
