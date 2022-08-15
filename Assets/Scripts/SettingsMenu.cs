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

    private float fixedDeltaTime;

    // Start is called before the first frame update
    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(settings.activeSelf == false && Time.timeScale == 1f)
            {
                settings.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                mainCam.GetComponent<CameraLock>().enabled = false;
                player.GetComponent<PlayerMover>().enabled = false;
                mc.GetComponent<FrameRateLock>().enabled = false;
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
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
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level_01");
    }

    public void continueGame()
    {
        confirmSound.Play();
        Time.timeScale = 1f;
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
