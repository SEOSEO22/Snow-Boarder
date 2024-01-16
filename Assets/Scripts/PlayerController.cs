using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueSize = 1f;
    [SerializeField] private float boostSpeed = 30f;
    [SerializeField] private float baseSpeed = 20f;
    Rigidbody2D rigid;
    SurfaceEffector2D surface;
    public bool canMove = true;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        surface = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove) {
            RotatePlayer();
            RespondToBoost();
        }
        else surface.speed = 0;
    }

    public void DisableControls() {
        canMove = false;
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            surface.speed = boostSpeed;
        else surface.speed = baseSpeed;
    }

    private void RotatePlayer()
    {
        // 플레이어 회전 설정
        if (Input.GetKey(KeyCode.LeftArrow))
            rigid.AddTorque(torqueSize);
        else if (Input.GetKey(KeyCode.RightArrow))
            rigid.AddTorque(-torqueSize);
    }
}
