using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    /// <summary>
    /// �����Ŀ�ʼ
    /// </summary>
    void Enter()
    {

    }
    /// <summary>
    /// ״̬���˳�
    /// </summary>
    void Exit()
    {

    }
    /// <summary>
    ///�߼���̬���£�ʵ��״̬���л�
    /// </summary>
    void LogicUpdate()//״̬�߼�����
    {

    }
    /// <summary>
    /// ����̬����
    /// </summary>
    void PhysicUpdate()//״̬�������
    {

    }
}
