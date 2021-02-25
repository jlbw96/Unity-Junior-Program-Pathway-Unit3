using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Declare gameobject that we can assign to
    public GameObject obstaclePrefab;
    //spawn location for object
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    //floats for object spawn delay and repeat rate
    private float startDelay = 2;
    private float repeatRate = 2;
    //Declare playercontroller script to access variables
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //Call the SpawnObstacle function repeatedly based on the delay and repeat rate
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        //Reference the player controller script attached to the player
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        //If the game over boolean is false then continue to spawn objects
        if (playerControllerScript.gameOver == false)
        {
            //Instantiate the gameobject we are using at the position declared above
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
    
}
