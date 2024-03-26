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
        rb.isKinematic = false; // Начинаем с кинематикой
    }

    private void OnMouseDown()
    {
        rb.isKinematic = true; // Выключаем кинематику при поддержке
    }

    private void OnMouseUp()
    {
        rb.isKinematic = false; // Включаем кинематику при отпускании
    }

    private void OnMouseDrag()
    {
        Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mouse);

        // Задаем позицию Rigidbody непосредственно
        rb.MovePosition(objPos);
    }
}
