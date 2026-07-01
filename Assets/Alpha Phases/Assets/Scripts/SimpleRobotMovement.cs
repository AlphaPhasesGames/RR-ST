using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Rounding.Roundup
{
    public class SimpleRobotMovement : MonoBehaviour
    {
        public float moveSpeed = 3f;
        public float turnSpeed = 120f;
        public float gravity = -20f;

        public Animator animator;

        private CharacterController controller;
        private float verticalVelocity;

        void Start()
        {
            controller = GetComponent<CharacterController>();

            if (animator == null)
                animator = GetComponentInChildren<Animator>();
        }

        void Update()
        {
            float moveInput = Input.GetAxisRaw("Vertical");
            float turnInput = Input.GetAxisRaw("Horizontal");

            transform.Rotate(0f, turnInput * turnSpeed * Time.deltaTime, 0f);

            Vector3 move = transform.forward * moveInput * moveSpeed;

            if (controller.isGrounded && verticalVelocity < 0f)
            {
                verticalVelocity = -2f; // keeps him stuck gently to the floor
            }

            verticalVelocity += gravity * Time.deltaTime;
            move.y = verticalVelocity;

            controller.Move(move * Time.deltaTime);

            bool isWalking = Mathf.Abs(moveInput) > 0.01f;
            animator.SetBool("isWalking", isWalking);
        }
    }
}