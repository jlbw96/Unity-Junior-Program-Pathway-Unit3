using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declare rigidbody
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    //Grounded Check
    public bool isOnGround = true; 

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //If (spacebar is pressed and boolean isOnGround is currently true)
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //Add force to the rigidbody and set boolean to false;
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //If box collider collides with an object then boolean is set to true;
        isOnGround = true;
    }


}
