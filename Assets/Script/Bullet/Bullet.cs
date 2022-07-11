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

        // +Z 방향으로 Speed만큼 전진시킨다.
        _Rigidbody.velocity = transform.forward * Speed;

        // 3초 뒤에 자신의 게임 오브젝트 파괴
        // (게임 오브젝트, 지연시간)
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // 이 안에서 가져와야함 Collider와 연결되어야 하는 것 같음
            PlayerHealth _PlayerHealth = other.GetComponent<PlayerHealth>();
            if (_PlayerHealth != null)
            {
                _PlayerHealth.Die();
            }
        }
    }
}
