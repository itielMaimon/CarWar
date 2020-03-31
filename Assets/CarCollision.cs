using UnityEngine;

public class CarCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
            Debug.Log("Hit at Obstacle");
    }
}
