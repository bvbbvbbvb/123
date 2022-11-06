using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerStateMachine :StateMachine
{
    //----״̬��ӵ�����е�״̬�࣬�������ǽ��й�����л�����״̬��ר�Ÿ���������״̬��
    //----״̬������ǰ״̬�ĸ���
     Animator animator;//���ն���
    [SerializeField] PlayerState[] playerStates;
    PlayerInput input;
    PlayerController controller;
    private void Awake()
    {
        animator=GetComponentInChildren<Animator>();
        input = GetComponent<PlayerInput>();
        controller = GetComponent<PlayerController>();
        stateTable = new Dictionary<System.Type, IState>(playerStates.Length);//��ʼ���ֵ�
        foreach(PlayerState state in playerStates)//ѭ����ʼ��״̬
        {
            state.Initialize(animator, input, this, controller);
            stateTable.Add(state.GetType(), state);//��Ϊ�����������
        }
    }
    private void Start()
    {
        SwichOn(stateTable[typeof(PlayerState_Idel)]);
    }
}
