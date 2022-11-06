using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class StateMachine : MonoBehaviour
{
    //----状态机拥有所有的状态类，并对他们进行管理和切换
    //----状态机负责当前状态的更新
    IState currentState;//当前状态
    protected Dictionary<System.Type,IState> stateTable;//状态表
    private void Update()
    {
        currentState.LogicUpdate();
    }
    private void FixedUpdate()
    {
        currentState.PhysicUpdate();
    }
    protected void SwichOn(IState newState)//当前状态的启用
    {
        currentState = newState;
        currentState.Enter();
    }
    public void SwichState(IState newState)//当前状态的切换
    {
        currentState.Exit();
        currentState = newState;//状态更新
        currentState.Enter();
    }public void SwichState(System.Type type)//当前状态的切换
    {
        currentState.Exit();
        currentState = stateTable[type];
        currentState.Enter();
    }
}
