using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    private int health;

    private float speed;
    public float stoppingdist;
    public float retreatdis;
    public Transform player;

    private float timebtwshots;
    private float startTimebtwshots;

    public GameObject projectile;
    public TimeManager timemanager;

    public ParticleSystem particle;
    public AudioSource enemydeath;
    public AudioSource enemyshoot;

    void Start()
    {
        health=Random.Range(10,20);
        speed=Random.Range(10,17);
        startTimebtwshots=Random.Range(1.5f,2f);
       stoppingdist=Random.Range(5f,10f);
       retreatdis=Random.Range(2f,6f);
         player=GameObject.FindGameObjectWithTag("Player").transform;
         particle=GameObject.FindGameObjectWithTag("particle").GetComponent<ParticleSystem>();
         timemanager=GameObject.FindGameObjectWithTag("time").GetComponent<TimeManager>();
         enemydeath=GameObject.FindGameObjectWithTag("audio").GetComponent<AudioSource>();
         enemyshoot=GameObject.Find("lasershoot").GetComponent<AudioSource>();
        timebtwshots=startTimebtwshots;
    }

    void Update() {
if (player!=null)
{
        if(Vector2.Distance(transform.position,player.position)>stoppingdist){
            transform.position=Vector2.MoveTowards(transform.position,player.position,speed*Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position,player.position)>stoppingdist && Vector2.Distance(transform.position,player.position)>retreatdis){
                 transform.position=this.transform.position;
        }
        else if(Vector2.Distance(transform.position,player.position)<retreatdis){
            transform.position=Vector2.MoveTowards(transform.position,player.position,-speed*Time.deltaTime);
        }

        if(timebtwshots<=0){
            enemyshoot.Play();
            Instantiate(projectile,transform.position,Quaternion.identity);
            timebtwshots=startTimebtwshots;

        }else
        {
        timebtwshots-=Time.deltaTime;
        }
}
    }


      public void TakeDamage(int damage)
{
      health-=damage;
      particle.transform.position=transform.position;
    particle.Play();

    if(health <=0)
    {
       
        Die();
    }

}
void Die ()
{
    if(charactermovement.health<120)
    {
    charactermovement.health=charactermovement.health+10;
    }
    Score.score++;
    particle.transform.position=transform.position;
    enemydeath.Play();
    particle.Play();
   
    Destroy(gameObject);
}

}

