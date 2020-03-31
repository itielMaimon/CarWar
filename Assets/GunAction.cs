﻿using UnityEngine;

public class GunAction : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 50f;

    public GameObject car;
    public ParticleSystem flash;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        flash.Play();

        RaycastHit hit;
        if (Physics.Raycast(car.transform.position, car.transform.forward, out hit, range))
        {
            RedCarTarget target = hit.transform.GetComponent<RedCarTarget>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
}