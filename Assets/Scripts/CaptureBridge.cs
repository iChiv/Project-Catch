using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureBridge : MonoBehaviour
{
    RaycastHit hit;
    public GameObject BlockChecked1;
    public GameObject BlockChecked2;
    public GameObject BlockChecked3;

    public GameObject BridgePicInShoot;
    public GameObject BridgePicInProjection;


    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit, 30))
        {
            if(hit.collider.tag =="AblgeToCapture" && hit.collider.name =="bridge_block1")
            {
                BlockChecked1.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    BridgePicInShoot.SetActive(true);
                    BridgePicInProjection.SetActive(true);
                }
            }
            else
            {
                BlockChecked1.SetActive(false);
            }
            if (hit.collider.tag == "AblgeToCapture" && hit.collider.name == "bridge_block2")
            {
                BlockChecked2.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    BridgePicInShoot.SetActive(true);
                    BridgePicInProjection.SetActive(true);
                }
            }
            else
            {
                BlockChecked2.SetActive(false);
            }
            if (hit.collider.tag == "AblgeToCapture" && hit.collider.name == "bridge_block3")
            {
                BlockChecked3.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    BridgePicInShoot.SetActive(true);
                    BridgePicInProjection.SetActive(true);
                }
            }
            else
            {
                BlockChecked3.SetActive(false);
            }
        }
    }

    private void OnDisable()
    {
        BlockChecked1.SetActive(false);
        BlockChecked2.SetActive(false);
        BlockChecked3.SetActive(false);
    }
}
