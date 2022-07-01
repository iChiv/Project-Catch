using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    CharacterController playerController;

    Vector3 direction;

    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float jumpFroce = 5;
    [SerializeField] float gravity = 5f;

    //[SerializeField] float mouseSpeed = 5f;
    //public float minMouseY = -45f;
    //public float minMouseX = 45f;

    //public float RotationY = 0f;
    //public float RotationX = 0f;

    //public Transform agretctCamera;

    // Start is called before the first frame update
    //[System.Obsolete]
    void Start()
    {
        playerController = GetComponent<CharacterController>();
        //Screen.lockCursor = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        if(playerController.isGrounded)
        {
            direction = new Vector3(_horizontal,0,_vertical);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                direction.y = jumpFroce;
            }
        }

        direction.y -= gravity * Time.deltaTime;
        playerController.Move(playerController.transform.TransformDirection(direction * moveSpeed * Time.deltaTime));

        //RotationX += agretctCamera.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSpeed;
        //RotationY -= Input.GetAxis("Mouse Y") * mouseSpeed;
        //this.transform.eulerAngles = new Vector3(0, RotationX, 0);
        //agretctCamera.transform.eulerAngles = new Vector3(RotationY, RotationX, 0);
    }
}
