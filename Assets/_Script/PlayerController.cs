using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    private float horizontal;

    float vertical;

    // 将速度暴露出来，使其可调
    public float speed = 0.1f;

    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // 每帧调用一次 Update
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidBody.position = position;
        //////////////////////////////////////
    }
}