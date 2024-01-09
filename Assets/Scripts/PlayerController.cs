using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueSize = 1f;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        // 플레이어 회전 설정
        if (Input.GetKey(KeyCode.LeftArrow))
            rigid.AddTorque(torqueSize);
        else if (Input.GetKey(KeyCode.RightArrow))
            rigid.AddTorque(-torqueSize);
    }
}
