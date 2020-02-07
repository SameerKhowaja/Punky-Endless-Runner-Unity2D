using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Finish")
        {
            Destroy(gameObject);

            //score add
        }

        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
        }
    }
}
