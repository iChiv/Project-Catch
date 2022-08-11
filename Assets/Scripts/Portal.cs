using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Portal : MonoBehaviour
{
    public int count;
    public GameObject player;
    //public UnityEvent OnTrigger;
    //public GameObject blackRaw;
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
        if(other.gameObject == player)
        {
            int count = GameObject.Find("CoinCountSave").GetComponent<CoinsCountSave>().count;
            SceneManager.LoadScene("Ending");
        }
        //OnTrigger.Invoke();
        //blackRaw.GetComponent<FadeInOut>().EndScene();
    }
}
