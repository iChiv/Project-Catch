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
    private bool guide4 = true;
    private bool guide5 = true;
    private bool guide6 = true;
    private bool guide7 = true;
    private bool guide8 = true;
    private bool guide9 = true;
    private bool guide10 = true;
    private bool guide11 = true;
    private bool guide12 = true;
    private bool guide13 = true;
    private bool guide14 = true;


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
    }
}
