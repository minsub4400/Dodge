using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        // ���� ������Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);
        // gameObject�� �ڱ� �ڽ��� ���� ������Ʈ��.
    }
}