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
    }
}
