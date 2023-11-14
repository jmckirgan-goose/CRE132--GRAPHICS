using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour {

    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnMovement(InputValue value) {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0) {


            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            animator.SetBool("IsWalking", true);
        } else {
            animator.SetBool("IsWalking", false);
        }
    }
    private void FixedUpdate()
    {
        Debug.Log(movement);
        float speed = 3.0f;
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
    
}
