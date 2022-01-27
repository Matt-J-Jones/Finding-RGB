using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{
    private Rigidbody2D rb2d;

private bool isGrounded;
public Transform groundCheck;
public float checkRadius;
public LayerMask whatIsGround;

public int jumpForce;
private int extraJumps;
public int totalJumps;
public Item Walking;
public Item Jumping;

    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame

    void Update()
    {
        if (isGrounded == false)
        {
            Walking.gameObject.SetActive(false);
            Jumping.gameObject.SetActive(true);
        } else {
            Walking.gameObject.SetActive(true);
            Jumping.gameObject.SetActive(false);
        }
        
        
        if (isGrounded == true)
        {
            extraJumps = totalJumps;
        }

        if(Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb2d.velocity = (Vector2.up * jumpForce);
            extraJumps --;
        } else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            rb2d.velocity = (Vector2.up * jumpForce);
        }
    }
    void FixedUpdate()
    {
    isGrounded = Physics2D.OverlapCircle(
        groundCheck.position, 
        checkRadius, 
        whatIsGround);
    }
}
