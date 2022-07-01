using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    public float sensitivityHor = 3f;
    public float sensitivityVer = 3f;
    public float upVer = -85;
    public float downVer = 85;
    private float rotVer;

    // Start is called before the first frame update
    void Start()
    {
        rotVer = transform.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseVer = Input.GetAxis("Mouse Y");
        float mouseHor = Input.GetAxis("Mouse X");
        rotVer -= mouseVer * sensitivityVer;
        rotVer = Mathf.Clamp(rotVer, upVer, downVer);
        transform.localEulerAngles = new Vector3(rotVer, 0, 0);
        transform.parent.Rotate(Vector3.up * mouseHor);
    }
}