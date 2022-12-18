using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 rotate_angle;
   
    void Update()
    {
        transform.Rotate(rotate_angle); 
    }
}
