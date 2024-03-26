using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObj : MonoBehaviour
{
    float distance = 3;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false; // �������� � �����������
    }

    private void OnMouseDown()
    {
        rb.isKinematic = true; // ��������� ���������� ��� ���������
    }

    private void OnMouseUp()
    {
        rb.isKinematic = false; // �������� ���������� ��� ����������
    }

    private void OnMouseDrag()
    {
        Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mouse);

        // ������ ������� Rigidbody ���������������
        rb.MovePosition(objPos);
    }
}
