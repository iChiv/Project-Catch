using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceThings : MonoBehaviour
{
    RaycastHit hit;
    GameObject Gear;
    GameObject DoorClose2;
    GameObject WhiteRoom;
    GameObject DoorClose1;
    GameObject Projection1;
    GameObject Projection2;
    public GameObject DoorPicInProject;
    public GameObject DoorPicInShoot;

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
        if(Physics.Raycast(transform.position, transform.forward, out hit, 10) && DoorPicInProject.activeSelf == true)
        {
            if(hit.collider.tag == "AbleToPlace"&& hit.collider.name == "DoorClose2")
            {
                Projection2.gameObject.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    DoorClose2.gameObject.SetActive(false);
                    Projection2.gameObject.SetActive(false);
                    DoorPicInProject.gameObject.SetActive(false);
                    DoorPicInShoot.gameObject.SetActive(false);
                }
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
        }
        
    }
}
