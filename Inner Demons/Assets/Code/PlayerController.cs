using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    Animator anim;
    bool playerMoving;
    Vector2 lastMove;
 


    Rigidbody2D myRigidbody;

    public static Vector3 lastCall;


    

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

  
  
    }


    void Update()
    {
        Debug.Log(lastCall);

        if(DialogueManager.GetInstance().dialogueIsPlaying)
        {
            myRigidbody.velocity = Vector2.zero;
            anim.SetFloat("MoveX",0f);
            anim.SetFloat("MoveY",0f);
            anim.SetBool("PlayerMoving", false);
            return;
        }

        playerMoving = false;

        if(Input.GetAxisRaw("Horizontal") > 0.5f  || Input.GetAxisRaw("Horizontal") < -0.5f )
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidbody.velocity.y);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }
        if(Input.GetAxisRaw("Vertical") > 0.5f  || Input.GetAxisRaw("Vertical") < -0.5f )
        {
            //transform.Translate(new Vector3(0F, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }

 



}
