using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Jump_Force;

    bool canJump;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(canJump == true)
            {
                canJump = false;
                rb.velocity = Vector2.up * Jump_Force;
            }
        }

        if(Input.touchCount > 0 && canJump == true)
        {
            canJump = false;
            rb.velocity = Vector2.up * Jump_Force;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            canJump = true;
        }
    }
}
