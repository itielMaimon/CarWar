using UnityEngine;

public class FollowCar : MonoBehaviour
{

    public Transform car;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = car.position + offset;
    }
}
