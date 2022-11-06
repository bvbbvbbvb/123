using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/StateMachine/PlayerState/Idle",fileName ="PlayerState_Idle")]//�����ʲ��˵����ԣ�menuName�˵�����fileName�ļ���
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
            Debug.Log("�ܲ�");
            playerStateMachine.SwichState(typeof(PlayerState_Run));
        }
    }
}
