using UnityEngine;

public class BlueCarMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float carSpeed = 1000f;
    public float sideSpedd = 800f;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
            rb.AddForce(0, 0, carSpeed * Time.deltaTime);

        if (Input.GetKey("a"))
            rb.AddRelativeForce(-sideSpedd * Time.deltaTime, 0, 0);

        if (Input.GetKey("d"))
            rb.AddRelativeForce(sideSpedd * Time.deltaTime, 0, 0);

        if (Input.GetKey("s"))
            rb.AddRelativeForce(0, 0, -carSpeed * Time.deltaTime);
    }
}