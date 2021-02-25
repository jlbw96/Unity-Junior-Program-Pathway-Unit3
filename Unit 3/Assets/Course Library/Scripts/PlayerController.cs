using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Declare rigidbody
    private Rigidbody playerRb;
    //Declare a new animator
    private Animator playerAnim;

    public float jumpForce = 10;
    public float gravityModifier = 1;

    //Grounded Check
    public bool isOnGround = true;

    //Game Over Boolean, default = false;
    public bool gameOver = false;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //If (spacebar is pressed and boolean isOnGround is true and gameover is false)
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            //Add force to the rigidbody and set boolean to false;
            //Change animation to jump
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //If box collider collides with an object with ground tag then boolean is set to true;
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        //Else if collision with object with obstacle tag display debug text game over
        //set gameover boolean to true, set death animation to true and set int to 1
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }

}
