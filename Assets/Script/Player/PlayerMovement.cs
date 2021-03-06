using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // PlayerInput를 가져와야한다
    private PlayerInput myInput;
    // 이동을 위한 리지드바디를 가져온다
    private Rigidbody myRigid;
    // 이동 속도
    public float speed = 8.0f;

    void Start()
    {
        myInput = GetComponent<PlayerInput>();
        myRigid = GetComponent<Rigidbody>();
        // 자신이 포함되어있는 컴퍼넌트 중에 PlayerInput를 찾아서 input에 넣는다.
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

} // 클래스 끝.
