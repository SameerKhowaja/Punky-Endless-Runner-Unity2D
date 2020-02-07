using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        speed = Random.Range(200f, 280f);
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * speed * Time.fixedDeltaTime;
    }

}
