using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Die();
        }
    }

    public void Die()
    {
        // ���� ������Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);
        // gameObject�� �ڱ� �ڽ��� ���� ������Ʈ��.
    }
}