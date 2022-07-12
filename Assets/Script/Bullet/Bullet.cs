using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ����
// �÷��̾�� ������ �÷��̾ ����Ѵ�
// 3�� �ڿ� �ڽ��� �ı��Ѵ�
public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidBody;
    public float Speed = 3.0f;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.velocity = transform.forward * Speed;
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
            playerHealth.Die();
        }
    }
}
