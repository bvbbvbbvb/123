using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/StateMachine/PlayerState/Idle",fileName ="PlayerState_Idle")]//创建资产菜单特性，menuName菜单名，fileName文件名
public class PlayerState_Idel : PlayerState
{
    public override void Enter()
    {
        base.Enter();
        animator.Play("Unity_Chan_Idle");
    }
    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (input.Move)
        {
            Debug.Log("跑步");
            playerStateMachine.SwichState(typeof(PlayerState_Run));
        }
    }
}
