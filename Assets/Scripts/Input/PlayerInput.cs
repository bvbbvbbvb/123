using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerInput : MonoBehaviour
{
    PlayerInputActions playerinputActions;
    public Vector2 axes => playerinputActions.Gameplay.Axes.ReadValue<Vector2>();
    public bool Move => AxisX != 0;//poblic bool Move => axes.x!= 0Ҳ����
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
        Cursor.lockState = CursorLockMode.Locked;//�������
    }
    private void Update()
    {
        Debug.Log("PlayerInput��AxesXֵ�ǣ�" + AxisX);
        Debug.Log("PlayerInput��axes.xֵ�ǣ�" + axes.x);
    }
}
