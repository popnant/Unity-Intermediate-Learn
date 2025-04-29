using UnityEngine;
using UnityEngine.AI;

public class Patrol : State
{
    public Patrol(Enemy character, NavMeshAgent agent) : base(character, agent)
    {
        Name = STATE.PATROL;
    }
    
    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();
        Agent.SetDestination(PlayerController.Instance.transform.position);

        if (!Me._isPlayerInView)
        {
            NextState = new Idle(Me, Agent);
            Stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        Agent.ResetPath();
        base.Exit();
    }
}
