using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poster : MonoBehaviour
{
    public GameObject poster1;
    public GameObject poster2;
    public GameObject poster3;
    public GameObject poster4;

    public GameObject leftArrow;
    public GameObject rightArrow;

    public AudioSource confirmed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (poster1.activeSelf == true)
        {
            leftArrow.SetActive(false);
        }
        else
        {
            leftArrow.SetActive(true);
        }

        if (poster4.activeSelf == true)
        {
            rightArrow.SetActive(false);
        }
        else
        {
            rightArrow.SetActive(true);
        }
    }

    public void rightClick()
    {
        if (poster1.activeSelf == true)
        {
            confirmed.Play();
            poster1.SetActive(false);
            poster2.SetActive(true);
        }

        else if (poster2.activeSelf == true)
        {
            confirmed.Play();
            poster2.SetActive(false);
            poster3.SetActive(true);
        }

        else if (poster3.activeSelf == true)
        {
            confirmed.Play();
            poster3.SetActive(false);
            poster4.SetActive(true);
        }
    }

    public void leftClick()
    {
        if (poster4.activeSelf == true)
        {
            confirmed.Play();
            poster4.SetActive(false);
            poster3.SetActive(true);
        }

        else if (poster3.activeSelf == true)
        {
            confirmed.Play();
            poster3.SetActive(false);
            poster2.SetActive(true);
        }

        else if (poster2.activeSelf == true)
        {
            confirmed.Play();
            poster2.SetActive(false);
            poster1.SetActive(true);
        }
    }
}
