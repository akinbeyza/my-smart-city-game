using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkRunJump : MonoBehaviour
{
    private Animator animator;
    public float rotationSpeed = 300f; // Karakterin dönme hýzý

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        // Hareket yönünü hesapla
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Saða ve sola dönme
        transform.Rotate(0f, horizontalInput * rotationSpeed * Time.deltaTime, 0f);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 5f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool("isRunning", true);
            transform.Translate(new Vector3(0, 0, 10f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.J))
        {
            animator.SetBool("isJumping", true);
            transform.Translate(new Vector3(0, 0, 10f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }
    }
}