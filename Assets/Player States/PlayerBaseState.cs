using UnityEngine;

public abstract class PlayerBaseState
{
    public abstract void EnterState(charactermovement player);

    public abstract void Update(charactermovement player);

    public abstract void OnCollisionEnter2D(charactermovement player);
}
