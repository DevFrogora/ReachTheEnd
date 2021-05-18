using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public float horz;
    public float vert;

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit x: " + playerMovement.transform.position.z);
        if (playerMovement.transform.position.z >= 90f)
        {
            playerMovement.transform.position = new Vector3(playerMovement.transform.position.x, playerMovement.transform.position.y, 90f);
            playerMovement.rb.velocity = Vector3.zero;
            playerMovement.rb.angularVelocity = Vector3.zero;
        }
        if (playerMovement.transform.position.x <= -6.8f)
        {
            playerMovement.transform.position = new Vector3(-6.8f, playerMovement.transform.position.y, playerMovement.transform.position.z);
            playerMovement.rb.velocity = Vector3.zero;
            playerMovement.rb.angularVelocity = Vector3.zero;

        }
        if (playerMovement.transform.position.x >= 6f)
        {
            playerMovement.transform.position = new Vector3(6f, playerMovement.transform.position.y, playerMovement.transform.position.z);
            playerMovement.rb.velocity = Vector3.zero;
            playerMovement.rb.angularVelocity = Vector3.zero;
        }

        if (playerMovement.transform.position.z <= -3.7f)
        {
            playerMovement.transform.position = new Vector3(playerMovement.transform.position.x, playerMovement.transform.position.y, -3.6f);
            playerMovement.rb.velocity = Vector3.zero;
            playerMovement.rb.angularVelocity = Vector3.zero;

        }
    }
    // Update is called once per frame
    void Update()
    {



    }
}
