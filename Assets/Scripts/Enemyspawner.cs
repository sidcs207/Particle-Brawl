using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
   public GameObject prefab;

   public Transform player;
   public float x;
    public float y;
    void Start()
    {
        StartCoroutine(SpawnEnemies()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemies() {
           while(true){
        if(player!=null)
        {
            for (int i = 0; i <=Score.score/10; i++)
            {
            x=Random.Range(-13,14);
             y=Random.Range(-6,7);
             if(player.position.x!=x && player.position.y!=y)
                     {
                      
                         Instantiate(prefab,new Vector2(x,y),Quaternion.identity);
                    }
            }
         }
            else
                   {
            Destroy(gameObject);
                   }         

yield return new WaitForSeconds(Random.Range(1,5));
           }
    }
}
