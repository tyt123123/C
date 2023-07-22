using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  // 将速度暴露出来，使其可调
  public float speed = 0.1f;
  // 每帧调用一次 Update
  void Update()
  {
      float horizontal = Input.GetAxis("Horizontal");
      float vertical = Input.GetAxis("Vertical");
      Vector2 position = transform.position;
      position.x = position.x + speed * horizontal * Time.deltaTime;
      position.y = position.y + speed * vertical * Time.deltaTime;
      transform.position = position;
        //////////////////////////////////////
  }
    
}
