using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] private Texture2D aimTexture; // текстура прицела
    [SerializeField] private float aimSize = 64f; // размер прицела
    private Rect aimRect; // прямоугольник для отображения прицела

    private void Start()
    {
        // Вычисляем прямоугольник, в котором будет находиться прицел по центру экрана
        aimRect = new Rect((Screen.width - aimSize) / 2, (Screen.height - aimSize) / 2, aimSize, aimSize);
    }

    private void OnGUI()
    {
        // Отображаем текстуру прицела в центре экрана
        GUI.DrawTexture(aimRect, aimTexture);
    }
}

