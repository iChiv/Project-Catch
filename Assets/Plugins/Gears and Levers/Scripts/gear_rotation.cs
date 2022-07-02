using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear_rotation : MonoBehaviour
{

    public float speed = 20;
    public bool rotate_x_axis;
    public bool rotate_y_axis;
    public bool rotate_z_axis;

    void Update()
    {
        if (rotate_x_axis == true)
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
        }
        if (rotate_y_axis == true)
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
        if (rotate_z_axis == true)
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
    }
}