using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        GameManeger gameManeger = FindObjectOfType<GameManeger>();
        gameManeger.EndGame();
        // ���� ������Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);
        // gameObject�� �ڱ� �ڽ��� ���� ������Ʈ��.
    }
}