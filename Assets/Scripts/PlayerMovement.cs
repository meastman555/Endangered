using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //parameters that can be entered from the inspector window to allow for fine-tuning
    public float mySpeed;
    public float myJumpForce;

    //true if the player is on the ground
    private bool canJump;

    //componenets to manipulate the gameobject within this script
    private Rigidbody2D myRigidBody;
    private Collider2D myCollider;
    private SpriteRenderer mySpriteRenderer;
    private Animator myAnimator;
    public AudioSource jumpSound;

    //retrieve the components and allow player to jump (gameobject is initialized on the ground)
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CapsuleCollider2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        myAnimator = GetComponent<Animator>();
        canJump = true;
    }

    //update is called once per frame
    void Update()
    {
        //moving left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //flips sprite to be facing left and applies a vector for leftward movement
            mySpriteRenderer.flipX = false;
            myRigidBody.velocity = new Vector2(-mySpeed, myRigidBody.velocity.y);
            //if the player is not currently in the air play running animation
            if (canJump)
            {
                myAnimator.Play("PlayerRun");

            }
        }
        //moving right
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //flips sprite to be facing right and applies a vector for rightward movement
            mySpriteRenderer.flipX = true;
            myRigidBody.velocity = new Vector2(mySpeed, myRigidBody.velocity.y);
            //if the player is not currently in the air play running animation
            if (canJump)
            {
                myAnimator.Play("PlayerRun");
            }
        }
        //no directional input is given, but if the player is not currently in the air play idle animation
        else if (canJump)
        {
            myAnimator.Play("PlayerIdle");
        }

        //separate check to see if user wants to jump
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && canJump)
        {
            //plays animation and adds vector for upward movement (fall affected by gravity)
            myAnimator.Play("PlayerJump3");
            //jumpSound.Play();
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, myJumpForce);
            //makes sure the user cannot infinitely jump
            canJump = false;
        }
    }
    //after collision (with the ground) allows alien to jump again
    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }
}