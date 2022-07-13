using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // PlayerInput�� �����;��Ѵ�
    private PlayerInput myInput;
    // �̵��� ���� ������ٵ� �����´�
    private Rigidbody myRigid;
    // �̵� �ӵ�
    public float speed = 8.0f;

    void Start()
    {
        myInput = GetComponent<PlayerInput>();
        myRigid = GetComponent<Rigidbody>();
        // �ڽ��� ���ԵǾ��ִ� ���۳�Ʈ �߿� PlayerInput�� ã�Ƽ� input�� �ִ´�.
    }

    void Update()
    {
        float xSpeed = myInput.X * speed;
        float zSpeed = myInput.Z * speed;

        myRigid.velocity = new Vector3(xSpeed, 0f, zSpeed);

        /*if (myInput.Up == true)
        {
            myRigid.AddForce(0f, 0f, speed);
        }
        if (myInput.Down == true)
        {
            myRigid.AddForce(0f, 0f, -speed);
        }
        if (myInput.Left == true)
        {
            myRigid.AddForce(-speed, 0f, 0f);
        }
        if (myInput.Right == true)
        {
            myRigid.AddForce(speed, 0f, 0f);
        }*/
    }

} // Ŭ���� ��.
