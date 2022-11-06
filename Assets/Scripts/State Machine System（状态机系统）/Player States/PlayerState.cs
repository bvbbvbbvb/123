using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : ScriptableObject,IState
{
    protected Animator animator;
    protected PlayerInput input;
    protected PlayerStateMachine playerStateMachine;
    protected PlayerController controller;
    public void Initialize(Animator animator,PlayerInput input,PlayerStateMachine stateMachine,PlayerController controller)
    {
        this.animator = animator;
        this.input = input;
        this.playerStateMachine = stateMachine;
        this.controller = controller;
    }
    public virtual void Enter()
    {

    }
    public virtual void Exit()
    {

    }
    public virtual void LogicUpdate()//状态逻辑更新
    {

    }
    public virtual void PhysicUpdate()//状态物理更新
    {

    }
}
