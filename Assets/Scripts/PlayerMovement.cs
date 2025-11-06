using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PickaxeHandler pickaxeHandler;

    public float speed = 5f;

    Rigidbody2D myRigidbody;
    private Vector2 movement;
    private new Transform transform;
    public Animator animator;
    private float jumpForce = 10f;

    void Start()
    {
        pickaxeHandler = FindObjectOfType<PickaxeHandler>();
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();


        
    }

    
    void Update()
    {
        movement = Vector2.zero;
        if (Input.GetKey(KeyCode.D))
        {
            movement.x = speed;
            transform.localScale = new Vector3(2.5f, 2.5f, 1);
            animator.SetBool("walk", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movement.x = -speed;
            transform.localScale = new Vector3(-2.5f, 2.5f, 1);
            animator.SetBool("walk", true);
        }
        else if (Input.GetKey(KeyCode.Space))
        {

           myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);

        }
        else 
        {
            myRigidbody.velocity = new Vector2(0f, 0f);
            animator.SetBool("walk", false);
        }
       
    }

    void FixedUpdate()
    {
        myRigidbody.velocity = new Vector2(movement.x, myRigidbody.velocity.y);
        
    }
   
}
