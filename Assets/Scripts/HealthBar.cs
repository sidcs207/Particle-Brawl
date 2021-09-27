using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
  public Vector2 health;
    void Start()
    {
        health=transform.localScale;
    }
    void Update()
    {
       if(charactermovement.health>=0)
       {
        transform.localScale=new Vector2(charactermovement.health/10,1);
       }
    }
}
