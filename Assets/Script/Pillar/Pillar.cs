using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 플레이어 방향으로 회전
// 탄알은 랜덤 시간 간격으로 복제
public class Pillar : MonoBehaviour
{
    // 탄알 프리펩
    public GameObject bulletPrefab;
    private Transform target;

    // isShoot이 true면 쏘고 false면 안쏨
    public bool isShoot;

    public float minNumber = 0.5f;
    public float maxNumber = 3.0f;

    // 생성 주기
    private float bulletCycle;

    // 탄알 쏘고 난후 시간 저장
    private float timeAfter;

    void Start()
    {
        isShoot = false;
        bulletCycle = Random.Range(minNumber, maxNumber);
        timeAfter = 0f;
        target = FindObjectOfType<PlayerHealth>().transform;
    }

    void Update()
    {
        if (isShoot)
        {
            timeAfter += Time.deltaTime;

            if (timeAfter >= bulletCycle)
            {
                timeAfter = 0;
                Instantiate(bulletPrefab, transform.position, transform.rotation);
                transform.LookAt(target);
                bulletCycle = Random.Range(minNumber, maxNumber);
            }
        }
        else
        {
            transform.LookAt(target);
        }
    }
}
