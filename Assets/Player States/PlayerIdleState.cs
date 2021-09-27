using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState(charactermovement player)
    {
        
    }

    public override void OnCollisionEnter2D(charactermovement player)
    {
        
    }

    public override void Update(charactermovement player)
    {
      

       if (Input.GetAxisRaw("Vertical")!=0)
        {
            if(Input.GetAxisRaw("Vertical")>0)
            {
            player.TransitionToState(player.playerMoveTopState);
            }
            else if(Input.GetAxisRaw("Vertical")<0)
            {
                player.TransitionToState(player.playerMoveDownState);
            }
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
