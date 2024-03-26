using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] private Texture2D aimTexture; // �������� �������
    [SerializeField] private float aimSize = 64f; // ������ �������
    private Rect aimRect; // ������������� ��� ����������� �������

    private void Start()
    {
        // ��������� �������������, � ������� ����� ���������� ������ �� ������ ������
        aimRect = new Rect((Screen.width - aimSize) / 2, (Screen.height - aimSize) / 2, aimSize, aimSize);
    }

    private void OnGUI()
    {
        // ���������� �������� ������� � ������ ������
        GUI.DrawTexture(aimRect, aimTexture);
    }
}

