using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _Rigidbody;
    public float Speed;
    void Start()
    {
        _Rigidbody = GetComponent<Rigidbody>();
        Speed = 8.0f;

        // +Z �������� Speed��ŭ ������Ų��.
        _Rigidbody.velocity = transform.forward * Speed;

        // 3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        // (���� ������Ʈ, �����ð�)
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // �� �ȿ��� �����;��� Collider�� ����Ǿ�� �ϴ� �� ����
            PlayerHealth _PlayerHealth = other.GetComponent<PlayerHealth>();
            if (_PlayerHealth != null)
            {
                _PlayerHealth.Die();
            }
        }
    }
}
