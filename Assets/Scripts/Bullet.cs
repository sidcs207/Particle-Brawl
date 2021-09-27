using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity=transform.right*speed;
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
       enemy en= hitinfo.GetComponent<enemy>();
       if(en!=null)
       {
           en.TakeDamage(10);
       }
        Destroy(gameObject);
    }
   
}
