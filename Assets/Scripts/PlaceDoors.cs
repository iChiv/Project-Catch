using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDoors : MonoBehaviour
{
    public AudioSource projectSound;
    public GameObject mainCam;
    RaycastHit hit;
    GameObject Gear;
    GameObject DoorClose2;
    GameObject WhiteRoom;
    GameObject DoorClose1;
    GameObject Projection1;
    GameObject Projection2;

    [SerializeField] GameObject DoorPic;
    [SerializeField] GameObject DoorPicPro;

    [SerializeField] GameObject DoorOpen1;
    [SerializeField] GameObject DoorOpen2;
    [SerializeField] GameObject DoorOpen3;

    [SerializeField] GameObject DoorClose3;
    [SerializeField] GameObject Projection3;
    [SerializeField] GameObject GuideUIwasd;

    [SerializeField] GameObject placeable1;
    [SerializeField] GameObject placeable11;
    [SerializeField] GameObject placeable2;
    [SerializeField] GameObject placeable21;
    [SerializeField] GameObject placeable22;


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
        if(DoorPic.activeSelf == true)
        {
            placeable1.SetActive(true);
            placeable2.SetActive(true);
            placeable11.SetActive(true);
            placeable21.SetActive(true);
            placeable22.SetActive(true);
        }
        else
        {
            placeable1.SetActive(false);
            placeable2.SetActive(false);
            placeable11.SetActive(false);
            placeable21.SetActive(false);
            placeable22.SetActive(false);
        }


        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 30) && DoorPic.activeSelf == true)
        {
            //Debug.Log(hit.collider.name);
            if(hit.collider.tag == "AbleToPlace"&& hit.collider.name == "DoorClose2")
            {
                Projection2.gameObject.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    projectSound.Play();
                    DoorClose2.gameObject.SetActive(false);
                    Projection2.gameObject.SetActive(false);
                    DoorPic.gameObject.SetActive(false);
                    DoorPicPro.SetActive(false);
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
                    projectSound.Play();
                    DoorClose1.gameObject.SetActive(false);
                    Projection1.gameObject.SetActive(false);
                    DoorPic.gameObject.SetActive(false);
                    DoorPicPro.SetActive(false);
                    DoorOpen1 .GetComponent<BoxCollider>().enabled = true;
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
                    projectSound.Play();
                    DoorClose3.gameObject.SetActive(false);
                    Projection3.gameObject.SetActive(false);
                    DoorPic.gameObject.SetActive(false);
                    DoorPicPro.SetActive(false);
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
