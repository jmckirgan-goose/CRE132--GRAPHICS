using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour {

    private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMovement (InputValue value) {
        movement = value.Get<Vector2>();
        
    }

    private void FixedUpdate() {
        float speed = 3.0f;
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
