using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float moveSpeed = 3;

    public const string RIGHT = "right";
    public const string LEFT = "left";

    string buttonPressed;

    private bool facingRight = true;

    private Animator anim;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            buttonPressed = RIGHT;
            anim.Play("Player_Walk");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            buttonPressed = LEFT;
            anim.Play("Player_Walk");
        }
        else
        {
            buttonPressed = null;
            anim.Play("Idle");
        }
    }

    void FixedUpdate()
    {
        if (buttonPressed == RIGHT)
        {
            rb2d.AddForce(new Vector2(moveSpeed, 0), ForceMode2D.Impulse);
        }
        else if (buttonPressed == LEFT)
        {
            rb2d.AddForce(new Vector2(-moveSpeed, 0), ForceMode2D.Impulse);
        }

        if (facingRight == false && buttonPressed == RIGHT)
        {
            Flip();
        } else if (facingRight == true && buttonPressed == LEFT)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
