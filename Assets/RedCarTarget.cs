﻿using UnityEngine;

public class RedCarTarget : MonoBehaviour
{
    public float health = 100f;

    public HealthBar healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(health);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        healthBar.SetHealth(health);

        Debug.Log("Hit");

        // If health reached 0, destroy the car.
        if(health <= 0f)
        {
            DestroyCar();
        }
    }

    void DestroyCar()
    {
        Destroy(gameObject);
    }
}
