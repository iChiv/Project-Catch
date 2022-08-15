using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camUI;
    public GameObject camera;
    
    [Range(0.001f, 0.1f)]
    public float movingSpeed = 0.001f;
    public float maxRotation = 10f;
    private Vector3 camForward;
    private Vector3 camForwardNow;
    private bool isCatching = false;

    private void OnEnable()
    {
        camForward = camera.GetComponent<Camera>().transform.forward;
        catchCamera();
    }

    // Update is called once per frame
    void Update()
    {
        camForwardNow = camera.GetComponent<Camera>().transform.forward;

        uiRotate();

        if (isCatching) 
        {
            uiRotate();
        }

        if (Input.GetKeyDown(KeyCode.H)) 
        {
            catchCamera();
        }
        
    }

    public void catchCamera() //call func when ui open
    {
        camForward = camera.GetComponent<Camera>().transform.forward;
        isCatching = true;
    }

    public void catchCameraPause() //call func when ui close
    {
        camUI.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        isCatching = false;
    }
    public void uiRotate()
    {
        
        float yPortion = ((camForwardNow.normalized - camForward.normalized)).y*-1f;
        float xPortion = ((camForwardNow.normalized - camForward.normalized)).x;
        float camX;
        float camY;
        //Debug.Log(yPortion);

        #region

        if ((camForwardNow - camForward).y < 0f) //when camera is moving up
        {
            
            camX = Mathf.Lerp(camForwardNow.x, 1f * maxRotation * yPortion, movingSpeed);
            //x axis -
            
        }
            else 
        {
            camX = Mathf.Lerp(camForwardNow.x, maxRotation * yPortion, movingSpeed);
            //x axis +
        }
        #endregion



        if ((camForwardNow - camForward).x < 0f) //when camera is moving left
        {
            camY = Mathf.Lerp(camForwardNow.y, 1f*maxRotation * xPortion, movingSpeed);
            //y axis + 
        }
            else 
        {
            camY = Mathf.Lerp(camForwardNow.y, maxRotation * xPortion, movingSpeed);
            //y axis - 
        }

        camUI.transform.rotation = Quaternion.Euler(camX, camY, 0f);

    }
}
