using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // ȸ�� �ӵ�
    public float RotationSpeed;

    void Start()
    {
        RotationSpeed = 60f;    
    }
    void Update()
    {
        transform.Rotate(0f, RotationSpeed * Time.deltaTime, 0f);
    }
}
