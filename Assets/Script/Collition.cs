using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collition : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Destroy(gameObject);
        }

    }
}
