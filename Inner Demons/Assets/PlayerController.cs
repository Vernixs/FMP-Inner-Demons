using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private Animator anim;

    /*Rigidbody2D myRigidbody;

    bool playerMoving;
    Vector2 lastMove;*/

    void Start()
    {
        /*myRigidbody = GetComponent<Rigidbody2D>();*/
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        /*playerMoving = false;*/

        if(Input.GetAxisRaw("Horizontal") > 0.5f  || Input.GetAxisRaw("Horizontal") < -0.5f )
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
           /* myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidbody.velocity.y);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);*/
        }
        if(Input.GetAxisRaw("Vertical") > 0.5f  || Input.GetAxisRaw("Vertical") < -0.5f )
        {
            transform.Translate(new Vector3(0F, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            /*myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Vertical"), 0f);*/
        }

        /*if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
        }*/

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    }
}
