using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 앞으로 직진
// 플레이어에게 닿으면 플레이어가 사망한다
// 3초 뒤에 자신을 파괴한다
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
