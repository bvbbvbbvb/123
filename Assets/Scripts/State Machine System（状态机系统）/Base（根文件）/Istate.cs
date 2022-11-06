using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    /// <summary>
    /// 动画的开始
    /// </summary>
    void Enter()
    {

    }
    /// <summary>
    /// 状态的退出
    /// </summary>
    void Exit()
    {

    }
    /// <summary>
    ///逻辑动态更新，实现状态的切换
    /// </summary>
    void LogicUpdate()//状态逻辑更新
    {

    }
    /// <summary>
    /// 物理动态更新
    /// </summary>
    void PhysicUpdate()//状态物理更新
    {

    }
}
