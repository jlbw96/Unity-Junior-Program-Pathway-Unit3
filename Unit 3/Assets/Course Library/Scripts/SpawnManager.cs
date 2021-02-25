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

    // Start is called before the first frame update
    void Start()
    {
        //Call the SpawnObstacle function repeatedly based on the delay and repeat rate
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        //Instantiate the gameobject we are using at the position declared above
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
    
}
