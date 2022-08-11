using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settings;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject player;
    public GameObject mc;

    public AudioMixer audiomixer;

    public AudioSource confirmSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(settings.activeSelf == false)
            {
                settings.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                mainCam.GetComponent<CameraLock>().enabled = false;
                player.GetComponent<PlayerMover>().enabled = false;
                mc.GetComponent<FrameRateLock>().enabled = false;
            }
            else
            {
                settings.SetActive(false);
                mainCam.GetComponent<CameraLock>().enabled = true;
                player.GetComponent<PlayerMover>().enabled = true;
                mc.GetComponent<FrameRateLock>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

    public void quitButton()
    {
        confirmSound.Play();
        Application.Quit();
    }

    public void restartGame()
    {
        confirmSound.Play();
        SceneManager.LoadScene("Level_01");
    }

    public void continueGame()
    {
        confirmSound.Play();
        settings.SetActive(false);
        mainCam.GetComponent<CameraLock>().enabled = true;
        player.GetComponent<PlayerMover>().enabled = true;
        mc.GetComponent<FrameRateLock>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void SetMasterVolume(float volume)
    {
        audiomixer.SetFloat("MasterVolume", volume);
    }
}
