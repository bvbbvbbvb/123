using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerInput : MonoBehaviour
{
    PlayerInputActions playerinputActions;
    public Vector2 axes => playerinputActions.Gameplay.Axes.ReadValue<Vector2>();
    public bool Move => AxisX != 0;//poblic bool Move => axes.x!= 0也可以
    public bool Jump => playerinputActions.Gameplay.Jump.WasPressedThisFrame();
    public bool StopJump => playerinputActions.Gameplay.Jump.WasReleasedThisFrame();
    public float AxisX => axes.x;
    private void Awake()
    {
        playerinputActions = new PlayerInputActions();
    }
    public void EnableGameplayInputs()
    {
        playerinputActions.Gameplay.Enable();
        Cursor.lockState = CursorLockMode.Locked;//光标锁定
    }
    private void Update()
    {
        Debug.Log("PlayerInput的AxesX值是：" + AxisX);
        Debug.Log("PlayerInput的axes.x值是：" + axes.x);
    }
}
