using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicCam : MonoBehaviour
{

    public float speed = 10.0f;

    public float horizontalSpeed = 2.0f; // чувствительность мыши по горизонтали
    public float verticalSpeed = 2.0f; // чувствительность мыши по вертикали
    public float minYAngle = -90.0f; // минимальный угол по оси Y
    public float maxYAngle = 90.0f; // максимальный угол по оси Y
    private float rotationX = -180.0f; // угол поворота по оси X
    private float rotationY = 0.0f; // угол поворота по оси Y

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked; // скрываем курсор мыши и фиксируем его в центре экрана
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // проверяем, зажата ли левая кнопка мыши
        {
            // получаем входное значение оси горизонтали мыши и изменяем угол поворота по оси X
            rotationX += Input.GetAxis("Mouse X") * horizontalSpeed;
            // получаем входное значение оси вертикали мыши и изменяем угол поворота по оси Y
            rotationY += Input.GetAxis("Mouse Y") * verticalSpeed;

            // ограничиваем угол поворота по оси Y между минимальным и максимальным значениями
            rotationY = Mathf.Clamp(rotationY, minYAngle, maxYAngle);

            // вращаем камеру вокруг осей X и Y
            //transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }

        float horizontalwalk = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(horizontalwalk, 0, vertical);
    }
}
