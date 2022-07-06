using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceThings : MonoBehaviour
{
    RaycastHit hit;
    GameObject Gear;
    GameObject DoorClose;
    GameObject WhiteRoom;
    GameObject Projection2;

    // Start is called before the first frame update
    void Start()
    {
        Gear = GameObject.Find("Gear");
        WhiteRoom = Gear.transform.GetChild(1).gameObject;
        DoorClose = WhiteRoom.transform.GetChild(4).gameObject;
        Projection2 = WhiteRoom.transform.GetChild(5).gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit, 1000))
        {
            if(hit.collider.tag == "AbleToPlace"&& hit.collider.name == "DoorClose2")
            {
                Projection2.gameObject.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    DoorClose.gameObject.SetActive(false);
                    Projection2.gameObject.SetActive(false);
                }
            }
        }
        
    }
}
