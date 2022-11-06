using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerInput input;
    Rigidbody RigidBody;
    private void Awake()
    {
        RigidBody = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();
    }
    private void Start()
    {
        input.EnableGameplayInputs();
    }
    public void Move(float speed)
    {
        Debug.Log("speed��ֵΪ��" + speed);
        //Debug.Log("PlayerController��AxisXֵ�ǣ�" + input.AxisX);
        SetVelocityX(speed * input.AxisX);//input.AxisX����Ҫ����
    }
    public void SetVelocity(Vector3 vector3)
    {
        RigidBody.velocity = vector3;
    }
    public void SetVelocityX(float X)
    {
        Debug.Log("X��ֵΪ��" + X);
        RigidBody.velocity = new Vector3(X, RigidBody.velocity.y);
    }
    public void SetVelocityY(float Y)
    {
        RigidBody.velocity = new Vector3(RigidBody.velocity.x, Y);
    }
}
