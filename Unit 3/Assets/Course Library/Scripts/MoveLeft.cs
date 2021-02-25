using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //Declare playercontroller script to access variables
    private PlayerController playerControllerScript;

    //Speed of left movement
    private float speed = 30;
    //Limit left before destroying gameObject
    private float leftBound = -15;

    void Start()
    {
        //Reference the player controller script attached to the player
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //If the game over boolean is false then translate the objects left
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //If object x position is less than leftbound value and tag is obstacle
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            //Destroy the gameobject to clear heirarchy
            Destroy(gameObject);
        }
    }

}
