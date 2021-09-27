using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    private Vector2 target;
    private Transform player;
    public ParticleSystem bulletspread;
    void Start()
    {
       player=GameObject.FindGameObjectWithTag("Player").transform;
        target=new Vector2(player.position.x,player.position.y);
        bulletspread=GameObject.Find("bulletspread").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector2.MoveTowards(transform.position,target,speed*Time.deltaTime);

        if(transform.position.x==target.x && transform.position.y==target.y)
        {
            DestroyProjectile();
        }
    }
 void OnTriggerEnter2D(Collider2D col)
 {
     if(col.CompareTag("Player")){
         charactermovement en= col.GetComponent<charactermovement>();
       if(en!=null)
       {
           en.PlayerHealth(10);
       }
         DestroyProjectile();
     }
 }
    void DestroyProjectile()
    {
        bulletspread.transform.position=transform.position;
       bulletspread.Play();
        Destroy(gameObject);
    }
}
