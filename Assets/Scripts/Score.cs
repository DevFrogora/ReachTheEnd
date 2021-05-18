using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if(playerMovement.enabled){

        scoreText.text = player.position.z.ToString("0");     
        }else{
            scoreText.text = "Dude you got Hit";
        }
    }
}
