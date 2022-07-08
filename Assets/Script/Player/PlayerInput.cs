using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool Up { get; private set; }
    // public���� �����ؾ� �ٸ� ���� ������Ʈ������ �����Ͽ� ����� �� ����.
    // private set���� ���ο����� ���� ���� �� �� �ֵ��� �Ͽ���.
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }
    
    void Update()
    {
        // �Ӽ� �ʱ�ȭ
        Up = Down = Left = Right = false;
        // ���� �������� �Է� ���� ����
        Up = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        Left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        Down = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        Right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);

        //�÷��̾ �׾��ٸ� ~ ����

    }


}
