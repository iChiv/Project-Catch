using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatingCoin : MonoBehaviour
{
    public GameObject coin;
    public GameObject player;

    public AudioSource coinSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("hi");
        if(other.gameObject == player)
        {
            GameObject.Destroy(coin);
            coinSound.Play();
        }
    }
}
