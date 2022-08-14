using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryIn5s : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(this, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Destroy(this, 5f);
    }
}
