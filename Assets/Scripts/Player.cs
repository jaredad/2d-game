 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = true;
    public int jumpPower = 1250;
    private float moveX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    void playerMove()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        moveX = Input.GetAxis("Horizontal");

        if(moveX < 0.0f && facingRight == true)
        {
            FlipPlayer();
        } else if(moveX >0.0f && facingRight == false)
        {
            FlipPlayer();
        }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);

    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 s = gameObject.transform.localScale;
        s.x *= -1;
        transform.localScale = s;
    }
}
