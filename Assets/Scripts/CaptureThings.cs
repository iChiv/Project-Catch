using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureThings : MonoBehaviour
{
    RaycastHit hit;
    public GameObject DoorOpen2;
    public GameObject DoorOpen3;
    public GameObject DoorPicInShoot;
    public GameObject DoorPicInProjection;
    public GameObject DoorCapable;
    public GameObject DoorCapable2;


    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit,30))
        {
            if (hit.collider.gameObject == DoorOpen2)
            {
                DoorCapable.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    DoorPicInShoot.SetActive(true);
                    DoorPicInProjection.SetActive(true);
                }
            }
            else
            {
                DoorCapable.SetActive(false);
            }

            if (hit.collider.gameObject == DoorOpen3)
            {
                DoorCapable2.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    DoorPicInShoot.SetActive(true);
                    DoorPicInProjection.SetActive(true);
                }
            }   
            else
            {
                DoorCapable2.SetActive(false);
            }
        }
    }

    private void OnDisable() 
    {
        DoorCapable.SetActive(false);
        DoorCapable2.SetActive(false);
        
    }
}