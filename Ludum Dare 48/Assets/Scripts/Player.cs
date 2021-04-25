using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
     public float speed = 250.0f;
     private Rigidbody2D _body;
     private BoxCollider2D _box;
    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
         _box = GetComponent<BoxCollider2D>();
    }

   
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector2 movement = new Vector2(deltaX, _body.velocity.y);
        _body.velocity = movement;
    }
}
