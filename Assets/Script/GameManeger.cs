using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 재시작, UI 관리
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; // TextMeshPro 쓰려면 사용해야 되는 것
using System; // MATH 쓸 수 있음

public class GameManeger : MonoBehaviour
{
    public GameObject gameOverText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI bestText;
    
    private bool isOver;
    private float surviveTime;
    private void Start()
    {
        isOver = false;
    }
    void Update()
    {
        if (!isOver)
        {
            surviveTime += Time.deltaTime;
            timeText.text = $"Time : {(int)surviveTime}";
        }
        else
        {
            if (isOver && Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    public void EndGame()
    {
        isOver = true;
        gameOverText.SetActive(true);
        float bestTime = PlayerPrefs.GetFloat("BestTime");
        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        bestText.text = $"Best Time : {(int)bestTime}";
    }

}
