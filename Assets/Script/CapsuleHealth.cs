using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleHealth : MonoBehaviour, IHealth
{
    [SerializeField] private float health;
    public GameObject coin;
    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health < 0)
        {
            gameObject.SetActive(false);
            for (int i = 0; i < 3; i++)
            {
                Instantiate(coin, transform.position, transform.rotation);
            }
        }
        
    }
}
