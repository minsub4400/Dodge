using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 재시작 및 UI 관리
using UnityEngine.UI; // UI 관련한 라이브러리
using UnityEngine.SceneManagement; // 씬 관련한 라이브러리

public class GameManeger : MonoBehaviour
{
    // 게임 오버 시 활성화 될 텍스트 게임 오브젝트
    public GameObject gameoverText;
    // 생존 시간을 표시할 텍스트 컴포넌트
    public Text timeText;
    // 최고 기록을 표시할 텍스트 컴포넌트
    public Text recordText;
    // 생존 시간
    private float surviveTime;
    // 게임 오버 상태
    private bool isGameover;

    void Start()
    {
        surviveTime = 0f;
        isGameover = false;
    }

    void Update()
    {
        if (!isGameover)
        {
            // 생존 시간 갱신
            surviveTime += Time.deltaTime;
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    //게임 오버 처리
    public void EndGame()
    {
        // 플레이어가 죽어서 게임이 종료 되었기 때문에 true로 바꾸어준다.
        isGameover = true;
        // 게임 오버 텍스트 활성화 시켜 주기
        gameoverText.SetActive(true);

        // Best Time key의 값을 저장
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        recordText.text = "Best Time : " + (int)bestTime;
    }

}
