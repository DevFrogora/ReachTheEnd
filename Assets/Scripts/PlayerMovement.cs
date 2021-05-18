
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sideForce = 30f;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, 500 * Time.deltaTime); // Added forced on Z axis to move the Player/Box/Cube on one axis
        transform.eulerAngles = new Vector3(0,0,0);
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            //transform.Rotate(new Vector3(0, 120, 0) * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //transform.Rotate(new Vector3(0, -120, 0) * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

    }

    public void addForce(){
        rb.AddForce(0,0,forwardForce*100 * Time.deltaTime);
    }
}
