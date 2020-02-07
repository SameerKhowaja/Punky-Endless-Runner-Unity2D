using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassMoveEffectScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.left * speed * Time.fixedDeltaTime);
        if(transform.position.x <= -19.4f)
        {
            transform.position = new Vector3(19.4f, transform.position.y, 0f);
        }
    }

}
