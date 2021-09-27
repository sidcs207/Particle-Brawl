using UnityEngine;
public class charactermovement : MonoBehaviour
{
  public float characterspeed;
  public Animator anim;
  public TimeManager timemanager;
  public AudioSource death;
  public AudioSource hurt;
public ParticleSystem PlayerDeath;
public Rigidbody2D rb;
public static float health=120;

public Rigidbody2D ri
{
  get{return rb;}
}

public PlayerBaseState currentState;

public PlayerBaseState CurrentState
{
  get{return currentState;}
}
public readonly PlayerIdleState playerIdleState=new PlayerIdleState();
public readonly PlayerMoveTopState playerMoveTopState=new  PlayerMoveTopState();
public readonly PlayerMoveRightState playerMoveRightState=new PlayerMoveRightState();
public readonly PlayerMoveLeftState playerMoveLeftState=new PlayerMoveLeftState();
public readonly PlayerMoveDownState playerMoveDownState=new PlayerMoveDownState();

private void Awake()
{
  rb=GetComponent<Rigidbody2D>();
}
private void Start()
{
TransitionToState(playerIdleState);
}
void Update()
{
  currentState.Update(this);
}

private void OnCollisionEnter2D(Collision2D collision)
{
  currentState.OnCollisionEnter2D(this);
}

public void TransitionToState(PlayerBaseState state)
{
  currentState=state;
  currentState.EnterState(this);
}
public void PlayerHealth(int damage){
  health-=damage;
  hurt.Play();
  if(health<=0)
  {
    Die();
  }
}
public void Die()
{
  timemanager.SlowMotion();
PlayerDeath.transform.position=transform.position;
PlayerDeath.Play();
death.Play();
Destroy(gameObject);
}
}
