using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField][Range(1f, 20f)] private float _distanseRay = 5f;
    [SerializeField] [Range(1f, 100f)] private float _damage = 10f;
    public Camera mainCam;
    public GameObject Capsule;
    private void OnMouseDown()
    {
        Shooting();
    }

    private void Update()
    {
        Shooting();
    }
    private void Shooting() //удар через райкаст, то есть нужно ткнуть в середину противника
   {
        Ray ray;
        ray = mainCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetKeyDown(KeyCode.E)&& hit.collider.TryGetComponent(out IHealth damagable))
            {
                damagable.TakeDamage(_damage);
            }
        }
        //var health = GameObject.FindGameObjectWithTag("Player").GetComponent<IHealth>();
            
        //if (health != null)
        //    health.TakeDamage(_damage);


   }
}
