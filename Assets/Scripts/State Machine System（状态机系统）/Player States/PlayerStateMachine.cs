using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerStateMachine :StateMachine
{
    //----状态机拥有所有的状态类，并对他们进行管理和切换（此状态机专门负责管理玩家状态）
    //----状态机负责当前状态的更新
     Animator animator;//接收动画
    [SerializeField] PlayerState[] playerStates;
    PlayerInput input;
    PlayerController controller;
    private void Awake()
    {
        animator=GetComponentInChildren<Animator>();
        input = GetComponent<PlayerInput>();
        controller = GetComponent<PlayerController>();
        stateTable = new Dictionary<System.Type, IState>(playerStates.Length);//初始化字典
        foreach(PlayerState state in playerStates)//循环初始化状态
        {
            state.Initialize(animator, input, this, controller);
            stateTable.Add(state.GetType(), state);//键为这个对象的类别
        }
    }
    private void Start()
    {
        SwichOn(stateTable[typeof(PlayerState_Idel)]);
    }
}
