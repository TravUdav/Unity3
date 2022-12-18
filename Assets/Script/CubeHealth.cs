using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHealth : MonoBehaviour, IHealth
{
    [SerializeField] private float health;
    public GameObject coin;

    public void TakeDamage(float damage) //нанесение урона
    {
        health -= damage;

        if (health < 0)
        {
            Destroy(gameObject);

            {
                Instantiate(coin, transform.position, transform.rotation);
            }
        }
    }
}
