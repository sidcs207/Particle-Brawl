using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject[] prefab;
    public Transform player;
    public float x;
    public float y;
void Start()
    {
        StartCoroutine(SpawnBoxes()); 
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBoxes() {
           while(true){
        if(player!=null)
        {  
            x=Random.Range(-10,14);
             y=6;
             if(player.position.x!=x && player.position.y!=y)
                     {
                      
                         Instantiate(prefab[Random.Range(0, prefab.Length)],new Vector2(x,y),Quaternion.identity);
                    }

         }
            else
                   {
            Destroy(gameObject);
                   }         

yield return new WaitForSeconds(Random.Range(7,12));
           }
    }

}
