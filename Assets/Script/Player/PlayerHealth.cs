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

        // Die �ż��尡 ���� �� ��,  GameManeger�� ������Ʈ�� ������ EndGame()�� �����Ŵ
        GameManeger _gameManeger = FindObjectOfType<GameManeger>();
        _gameManeger.EndGame();
    }
}