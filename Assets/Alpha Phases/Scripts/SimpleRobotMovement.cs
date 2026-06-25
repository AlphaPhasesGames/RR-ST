using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRobotMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float turnSpeed = 120f;

    public Animator animator;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        if (animator == null)
            animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Vertical");     // W/S + Up/Down arrows
        float turnInput = Input.GetAxisRaw("Horizontal");   // A/D + Left/Right arrows

        transform.Rotate(0f, turnInput * turnSpeed * Time.deltaTime, 0f);

        Vector3 move = transform.forward * moveInput * moveSpeed;
        controller.Move(move * Time.deltaTime);

        bool isWalking = Mathf.Abs(moveInput) > 0.01f;
        animator.SetBool("isWalking", isWalking);
    }
}
