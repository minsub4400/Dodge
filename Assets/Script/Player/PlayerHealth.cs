using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        // 게임 오브젝트 비활성화
        gameObject.SetActive(false);
        // gameObject는 자기 자신의 게임 오브젝트다.

        // Die 매서드가 실행 될 때,  GameManeger의 컴포넌트를 가져와 EndGame()를 실행시킴
        GameManeger _gameManeger = FindObjectOfType<GameManeger>();
        _gameManeger.EndGame();
    }
}