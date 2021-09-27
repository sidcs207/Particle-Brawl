using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public ParticleSystem particle;
    public AudioSource powerups;
    void OnCollisionEnter2D(Collision2D collision)
   {
       if (collision.gameObject.tag == "Player")
       {
           particle=GameObject.FindGameObjectWithTag("powerup").GetComponent<ParticleSystem>();
            particle.transform.position=transform.position;
           particle.Play();
            powerups= GameObject.FindGameObjectWithTag("Powerupsound").GetComponent<AudioSource>();
          powerups.Play();
          charactermovement.health=120;
          
          Destroy(gameObject);
       }
       else if (collision.gameObject.tag == "Finish")
       {
           particle=GameObject.FindGameObjectWithTag("powerup").GetComponent<ParticleSystem>();
            particle.transform.position=transform.position;
           particle.Play();
           powerups= GameObject.FindGameObjectWithTag("Powerupsound").GetComponent<AudioSource>();
          powerups.Play();
          Destroy(gameObject);
       }
       

   }
}
