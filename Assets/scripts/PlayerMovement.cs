using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f; // �������� �������� ���������
    private CharacterController controller;
    private Animator animator;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        moveDirection.y -= 9.81f * Time.deltaTime;

        controller.Move(moveDirection * Speed * Time.deltaTime);

        float moveMagnitude = new Vector2(horizontalInput, verticalInput).magnitude;

        if (moveMagnitude > 0.1f)
        { // �������� �������� �� ����� �������
            animator.SetFloat("Speed", moveMagnitude);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
    }
}
