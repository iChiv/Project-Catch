using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceColorRoom : MonoBehaviour
{
    public AudioSource projectSound;
    public GameObject mainCam;
    RaycastHit hit;
    int layerMask = 1 << 6;
    [SerializeField] GameObject RoomCheck;
    [SerializeField] GameObject colorRoomPic;
    [SerializeField] GameObject colorRoomPicPro;

    [SerializeField] GameObject RoomProCap;
    [SerializeField] GameObject blueRoom;
    [SerializeField] GameObject greenRoom;

    // Update is called once per frame
    void Update()
    {
        if(colorRoomPic.activeSelf == true)
        {
            RoomProCap.SetActive(true);
        }
        else
        {
            RoomProCap.SetActive(false);
        }

        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 50, layerMask) && colorRoomPic.activeSelf == true)
        {
            if(hit.collider.gameObject == RoomCheck)
            {
                RoomCheck.GetComponent<MeshRenderer>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    projectSound.Play();
                    RoomCheck.GetComponent<MeshRenderer>().enabled = false;
                    blueRoom.SetActive(false);
                    greenRoom.SetActive(true);

                    colorRoomPic.SetActive(false);
                    colorRoomPicPro.SetActive(false);
                }
            }
            else
            {
                RoomCheck.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
