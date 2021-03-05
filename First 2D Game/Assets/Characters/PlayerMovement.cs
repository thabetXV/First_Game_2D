using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private bool standing;
    public float speedSlow = 0.3f;
    public Vector2 maxVelocity = new Vector2(3, 4);
    private Rigidbody2D rg;
    private Animator animatationMove;
    // public AudioClip walkAudio;

    void Start()
    {
        animatationMove = GetComponent<Animator>();
    }

    void Update() {
        rg = GetComponent<Rigidbody2D>();
        float forceY = Mathf.Abs(rg.velocity.y);
        float forceX = Mathf.Abs(rg.velocity.x);
        standing = forceY < 0.2f ;

        var movX = 0f;
        var movY = 0f;
        
        if (rg.velocity.x != 0 && rg.velocity.y == 0)
        {
            // AudioSource.PlayClipAtPoint(walkAudio, transform.position);
            animatationMove.SetInteger("TransAnimator", 1);
        } else if (rg.velocity.y > 0) {
            animatationMove.SetInteger("TransAnimator", 2);
        } else {
            animatationMove.SetInteger("TransAnimator", 0);
        }
        
        
        if (Input.GetKey("right")) { 
            transform.localScale = new Vector3(1, 1, 1);
            if (forceX < maxVelocity.x)
                movX = standing ? speed : speed * speedSlow;
        } else if (Input.GetKey("left")) {
            transform.localScale = new Vector3(-1, 1, 1);
            if (maxVelocity.x > forceX)
                movX = standing ? -speed : -speed * speedSlow;
        }

        
        if ((Input.GetKey("up") || Input.GetKey("space")) && maxVelocity.y > forceY) {
            movY = speed;
        }


        rg.AddForce(new Vector3(movX, movY, 0));
    }
}
