using UnityEngine;

public class RedGunAction : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 50f;

    public GameObject gun;
    public ParticleSystem flash;
    public GameObject impactEffect;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        flash.Play();

        RaycastHit hit;
        if (Physics.Raycast(gun.transform.position, gun.transform.forward, out hit, range))
        {
            RedCarTarget target = hit.transform.GetComponent<RedCarTarget>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
}
