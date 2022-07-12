using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �÷��̾� �������� ȸ��
// ź���� ���� �ð� �������� ����
public class Pillar : MonoBehaviour
{
    // ź�� ������
    public GameObject bulletPrefab;
    private Transform target;

    // isShoot�� true�� ��� false�� �Ƚ�
    public bool isShoot;

    public float minNumber = 0.5f;
    public float maxNumber = 3.0f;

    // ���� �ֱ�
    private float bulletCycle;

    // ź�� ��� ���� �ð� ����
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
