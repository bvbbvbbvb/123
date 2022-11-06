using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class StateMachine : MonoBehaviour
{
    //----״̬��ӵ�����е�״̬�࣬�������ǽ��й�����л�
    //----״̬������ǰ״̬�ĸ���
    IState currentState;//��ǰ״̬
    protected Dictionary<System.Type,IState> stateTable;//״̬��
    private void Update()
    {
        currentState.LogicUpdate();
    }
    private void FixedUpdate()
    {
        currentState.PhysicUpdate();
    }
    protected void SwichOn(IState newState)//��ǰ״̬������
    {
        currentState = newState;
        currentState.Enter();
    }
    public void SwichState(IState newState)//��ǰ״̬���л�
    {
        currentState.Exit();
        currentState = newState;//״̬����
        currentState.Enter();
    }public void SwichState(System.Type type)//��ǰ״̬���л�
    {
        currentState.Exit();
        currentState = stateTable[type];
        currentState.Enter();
    }
}
