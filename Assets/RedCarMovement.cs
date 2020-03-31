using UnityEngine;

public class RedCarMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float carSpeed = 1000f;
    public float sideSpedd = 800f;

    // Update is called once per frame
    void FixedUpdate()
    {

        /*if (Input.GetKey("up"))
            rb.AddForce(0, 0, carSpeed * Time.deltaTime);

        if (Input.GetKey("left"))
            rb.AddRelativeForce(-sideSpedd * Time.deltaTime, 0, 0);

        if (Input.GetKey("right"))
            rb.AddRelativeForce(sideSpedd * Time.deltaTime, 0, 0);

        if (Input.GetKey("down"))
            rb.AddRelativeForce(0, 0, -carSpeed * Time.deltaTime);*/
    }
}