
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle") { 
        Debug.Log("we hit "+collisionInfo.collider.name); // we even hit the ground 
         playerMovement.enabled = false;
        }
    }
}
