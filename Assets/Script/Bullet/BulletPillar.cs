using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPillar : MonoBehaviour
{
    // 탄알 생산할 때 사용할 탄알 프리펩
    public GameObject bulletPrefap;
    // 탄알 생산 최소 값  
    public float Min = 0.5f;
    // 탄알 생산 최대 값
    public float Max = 3f;

    // 타겟(조준할 대상)
    private Transform target;
    // 생산 주기(다음 탄알을 생성할 때까지 기다릴 시간)
    private float productionCycle;
    // 탄알 생성 후, 흐른 시간
    private float timeAfter;

    void Start()
    {
        // Player 컴포넌트를 찾아 타겟과 위치를 저장하여 조준 대상으로 설정
        target = FindObjectOfType<PlayerMovement>().transform;
        
        timeAfter = 0f;
        // 탄알을 생산할 주기를 랜덤으로 Min, Max사이의 값으로 저장
        productionCycle = Random.Range(Min, Max);
    }


    void Update()
    {
        // 특정 시점으로 부터 시간이 얼마나 흘렸는지 알기 위함
        timeAfter += Time.deltaTime;

        // 생산 주기 보다 탄알이 오래 있으면
        if (timeAfter >= productionCycle)
        {
            // 0으로 리셋하고
            timeAfter = 0f;

            // 탄알 복제
            GameObject bullet = Instantiate(bulletPrefap, transform.position, transform.rotation);
            // 타겟을 바라보게 트랜스폼을 플레이어 방향으로 회전 시킨다.
            bullet.transform.LookAt(target);
            // 다시 탄알 생성을 랜덤하게 설정
            productionCycle = Random.Range(Min, Max);
        }
    }
}
