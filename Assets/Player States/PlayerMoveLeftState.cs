using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveLeftState : PlayerBaseState
{
    public override void EnterState(charactermovement player)
    {
    }

    public override void OnCollisionEnter2D(charactermovement player)
    {

    }

    public override void Update(charactermovement player)
    {
        
        if (Input.GetAxisRaw("Horizontal")<0)
        {
         player.anim.Play("walkback");
        float horinput=Input.GetAxis("Horizontal");
         player.transform.position=(Vector2)player.transform.position + new Vector2(horinput*player.characterspeed*Time.deltaTime,0);
        } 
         else if(Input.GetAxisRaw("Horizontal")>0)
        {
       player.TransitionToState(player.playerMoveRightState);
        }
         if(Input.GetButtonUp("Horizontal"))
       {      
              player.anim.Play("idle2");
           player.TransitionToState(player.playerIdleState);
       }
    }
}
