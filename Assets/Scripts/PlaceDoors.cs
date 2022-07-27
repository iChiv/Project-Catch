using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDoors : MonoBehaviour
{
    public GameObject mainCam;
    RaycastHit hit;
    GameObject Gear;
    GameObject DoorClose2;
    GameObject WhiteRoom;
    GameObject DoorClose1;
    GameObject Projection1;
    GameObject Projection2;
    public GameObject DoorPicInProject;
    public GameObject DoorPicInShoot;
    public GameObject DoorOpen2;
    public GameObject DoorOpen3;

    public GameObject DoorClose3;
    public GameObject Projection3;
    public GameObject GuideUIwasd;


    // Start is called before the first frame update
    void Start()
    {
        Gear = GameObject.Find("Gear");
        WhiteRoom = Gear.transform.GetChild(1).gameObject;
        DoorClose1 = WhiteRoom.transform.GetChild(1).gameObject;
        Projection1 = WhiteRoom.transform.GetChild(2).gameObject;
        DoorClose2 = WhiteRoom.transform.GetChild(4).gameObject;
        Projection2 = WhiteRoom.transform.GetChild(5).gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 30) && DoorPicInProject.activeSelf == true)
        {
            //Debug.Log(hit.collider.name);
            if(hit.collider.tag == "AbleToPlace"&& hit.collider.name == "DoorClose2")
            {
                Projection2.gameObject.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    DoorClose2.gameObject.SetActive(false);
                    Projection2.gameObject.SetActive(false);
                    DoorPicInProject.gameObject.SetActive(false);
                    DoorPicInShoot.gameObject.SetActive(false);
                    DoorOpen2.GetComponent<BoxCollider>().enabled = true;
                }
            }
            else
            {
                Projection2 .gameObject.SetActive(false);
            }
            if (hit.collider.tag == "AbleToPlace" && hit.collider.name == "DoorClose1")
            {
                Projection1.gameObject.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    DoorClose1.gameObject.SetActive(false);
                    Projection1.gameObject.SetActive(false);
                    DoorPicInProject.gameObject.SetActive(false);
                    DoorPicInShoot.gameObject.SetActive(false);
                }
            }
            else
            {
                Projection1.gameObject.SetActive(false);
            }
            if (hit.collider.tag == "AbleToPlace" && hit.collider.name == "DoorClose3")
            {
                Projection3.gameObject.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    DoorClose3.gameObject.SetActive(false);
                    Projection3.gameObject.SetActive(false);
                    DoorPicInProject.gameObject.SetActive(false);
                    DoorPicInShoot.gameObject.SetActive(false);
                    GuideUIwasd.gameObject.SetActive(false);
                    DoorOpen3.GetComponent<BoxCollider>().enabled = true;
                }
            }
            else
            {
                Projection3.gameObject.SetActive(false);
            }
        }
        
    }

    private void OnDisable() 
    {
        Projection1.SetActive(false);
        Projection2.SetActive(false);
        Projection3.gameObject.SetActive(false);
    }
}
