using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool Up { get; private set; }
    // public으로 설정해야 다른 게임 오브젝트에서도 접근하여 사용할 수 있음.
    // private set으로 내부에서는 값을 변경 할 수 있도록 하였음.
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }
    
    void Update()
    {
        // 속성 초기화
        Up = Down = Left = Right = false;
        // 현재 프레임의 입력 값을 저장
        Up = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        Left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        Down = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        Right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);

        //플레이어가 죽었다면 ~ 실행

    }


}
