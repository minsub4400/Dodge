using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // 회전 속도
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
