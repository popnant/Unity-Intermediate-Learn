using UnityEngine;
using UnityEngine.AI;

public class Idle : State
{
    public Idle(Enemy character, NavMeshAgent agent) : base(character, agent)
    {
        Name = STATE.IDLE;
    }

    public override void Enter()
    {
        base.Enter(); 

        if (Me._isPlayerInView)
        {
            NextState = new Patrol(Me, Agent);
            Stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        base.Exit();
    }
}
