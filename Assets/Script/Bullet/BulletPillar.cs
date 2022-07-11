using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPillar : MonoBehaviour
{
    // ź�� ������ �� ����� ź�� ������
    public GameObject bulletPrefap;
    // ź�� ���� �ּ� ��  
    public float Min = 0.5f;
    // ź�� ���� �ִ� ��
    public float Max = 3f;

    // Ÿ��(������ ���)
    private Transform target;
    // ���� �ֱ�(���� ź���� ������ ������ ��ٸ� �ð�)
    private float productionCycle;
    // ź�� ���� ��, �帥 �ð�
    private float timeAfter;

    void Start()
    {
        // Player ������Ʈ�� ã�� Ÿ�ٰ� ��ġ�� �����Ͽ� ���� ������� ����
        target = FindObjectOfType<PlayerMovement>().transform;
        
        timeAfter = 0f;
        // ź���� ������ �ֱ⸦ �������� Min, Max������ ������ ����
        productionCycle = Random.Range(Min, Max);
    }


    void Update()
    {
        // Ư�� �������� ���� �ð��� �󸶳� ��ȴ��� �˱� ����
        timeAfter += Time.deltaTime;

        // ���� �ֱ� ���� ź���� ���� ������
        if (timeAfter >= productionCycle)
        {
            // 0���� �����ϰ�
            timeAfter = 0f;

            // ź�� ����
            GameObject bullet = Instantiate(bulletPrefap, transform.position, transform.rotation);
            // Ÿ���� �ٶ󺸰� Ʈ�������� �÷��̾� �������� ȸ�� ��Ų��.
            bullet.transform.LookAt(target);
            // �ٽ� ź�� ������ �����ϰ� ����
            productionCycle = Random.Range(Min, Max);
        }
    }
}
