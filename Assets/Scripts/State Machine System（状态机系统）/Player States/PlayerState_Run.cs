using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/StateMachine/PlayerState/Run",fileName ="PlayerState_Run")]
public class PlayerState_Run : PlayerState
{
    [SerializeField] float runSpeed;
    public override void Enter()
    {
        base.Enter();
        animator.Play("Unity_Chan_Run");
    }
    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (!input.Move)
        {
            Debug.Log("œ–÷√");
            playerStateMachine.SwichState(typeof(PlayerState_Idel));
        }
    }
    public override void PhysicUpdate()
    {
        base.PhysicUpdate();
        controller.Move(runSpeed);
    }
}
