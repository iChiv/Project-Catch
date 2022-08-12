using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundGuides : MonoBehaviour
{
    public AudioSource startGuide;
    public AudioSource PickPoster;
    public AudioSource PickCam;
    public AudioSource leaveRoom;
    public AudioSource closeCliff;
    public AudioSource closeWaterfall;
    public AudioSource placeWf_s;
    public AudioSource catchWf_d;
    public AudioSource closeGear;
    public AudioSource catchGear;
    public AudioSource finishGear;
    public AudioSource catchSun;
    public AudioSource inYellow;
    public AudioSource finishGreen;

    private bool guide1 = true;
    private bool guide2 = true;
    private bool guide3 = true;
    //private bool guide4 = true;
    //private bool guide5 = true;
    //private bool guide6 = true;
    private bool guide7 = true;
    private bool guide8 = true;
    //private bool guide9 = true;
    private bool guide10 = true;
    private bool guide11 = true;
    private bool guide12 = true;
    //private bool guide13 = true;
    private bool guide14 = true;

    public GameObject posterUI;
    public GameObject mainCAM;
    public GameObject wf_s;
    public GameObject wf_dPic;
    public GameObject gear_sPic;
    public GameObject geared;
    public GameObject sunPic;
    public GameObject greenRoom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(guide1 == true)
        {
            startGuide.Play();
            guide1 = false;
        }

        if(guide2 == true && posterUI.activeSelf == true)
        {
            startGuide.Stop();
            PickPoster.Play();
            guide2 = false;
        }

        if(guide3 == true && mainCAM.activeSelf == true)
        {
            PickPoster.Stop();
            PickCam.Play();
            guide3 = false;
        }

        if(guide7 && wf_s.GetComponent<MeshRenderer>().enabled == true)
        {
            placeWf_s.Play();
            guide7 = false;
        }

        if(guide8 && wf_dPic.activeSelf == true)
        {
            catchWf_d.Play();
            guide8 = false;
        }

        if (guide10 && gear_sPic.activeSelf == true)
        {
            catchGear.Play();
            guide10 = false;
        }

        if(guide11 && geared.activeSelf == true)
        {
            finishGear.Play();
            guide11 = false;
        }

        if(guide12 && sunPic.activeSelf)
        {
            catchSun.Play();
            guide12 = false;
        }

        if(guide14 && greenRoom.activeSelf)
        {
            finishGreen.Play();
            guide14 = false;
        }
    }
}
