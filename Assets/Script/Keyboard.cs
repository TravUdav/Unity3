using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public float speed;

    public float currSpeed;

    public void Slower(float slow)
    {
        currSpeed = speed * slow / 100;
    }
    public void ReturnSpeed()
    {
        currSpeed = speed;
    }


    void Start()
    {
        currSpeed = speed;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * currSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * currSpeed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime * currSpeed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime * currSpeed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * Time.deltaTime * currSpeed;
        }
    }
}
