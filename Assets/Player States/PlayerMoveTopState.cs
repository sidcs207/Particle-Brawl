using UnityEngine;

public class PlayerMoveTopState : PlayerBaseState
{
    public override void EnterState(charactermovement player)
    {
    
    }

    public override void OnCollisionEnter2D(charactermovement player)
    {

        player.TransitionToState(player.playerIdleState);
        
    }

    public override void Update(charactermovement player)
    {
       if(Input.GetAxisRaw("Vertical")>0)
        {
        player.anim.Play("walk");
        float verinput=Input.GetAxis("Vertical");
         player.transform.position=(Vector2)player.transform.position + new Vector2(0,verinput*player.characterspeed*Time.deltaTime);
        }
        else if (Input.GetAxisRaw("Vertical")<0)
        {
         player.TransitionToState(player.playerMoveDownState);
         
        }
        
       if(Input.GetButtonUp("Vertical"))
       {      
              player.anim.Play("Idle");
           player.TransitionToState(player.playerIdleState);
       }
        if (Input.GetAxisRaw("Horizontal")!=0)
        {
            if(Input.GetAxisRaw("Horizontal")>0)
            {
            player.TransitionToState(player.playerMoveRightState);
            }
            else if(Input.GetAxisRaw("Horizontal")<0)
            {
                player.TransitionToState(player.playerMoveLeftState);
            }
        }
       
    }
}
