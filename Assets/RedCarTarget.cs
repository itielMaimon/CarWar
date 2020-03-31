using UnityEngine;

public class RedCarTarget : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;

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
