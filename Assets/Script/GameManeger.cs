using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ����� �� UI ����
using UnityEngine.UI; // UI ������ ���̺귯��
using UnityEngine.SceneManagement; // �� ������ ���̺귯��

public class GameManeger : MonoBehaviour
{
    // ���� ���� �� Ȱ��ȭ �� �ؽ�Ʈ ���� ������Ʈ
    public GameObject gameoverText;
    // ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text timeText;
    // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText;
    // ���� �ð�
    private float surviveTime;
    // ���� ���� ����
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
            // ���� �ð� ����
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

    //���� ���� ó��
    public void EndGame()
    {
        // �÷��̾ �׾ ������ ���� �Ǿ��� ������ true�� �ٲپ��ش�.
        isGameover = true;
        // ���� ���� �ؽ�Ʈ Ȱ��ȭ ���� �ֱ�
        gameoverText.SetActive(true);

        // Best Time key�� ���� ����
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        recordText.text = "Best Time : " + (int)bestTime;
    }

}
