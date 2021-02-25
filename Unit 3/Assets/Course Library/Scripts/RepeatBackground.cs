using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //Declaring start postition vector for the background
    private Vector3 startPos;
    private float repeatWidth;

    void Start()
    {
        //startPos = current object position
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //If object position x is less than startPos x - 50 
        if (transform.position.x < startPos.x - repeatWidth)
        {
            //Reset position back to the original position
            transform.position = startPos;
        }
    }
}
