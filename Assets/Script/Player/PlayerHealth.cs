using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        GameManeger gameManeger = FindObjectOfType<GameManeger>();
        gameManeger.EndGame();
        // 게임 오브젝트 비활성화
        gameObject.SetActive(false);
        // gameObject는 자기 자신의 게임 오브젝트다.
    }
}