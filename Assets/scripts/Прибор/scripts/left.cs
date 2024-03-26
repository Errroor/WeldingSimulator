using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left : MonoBehaviour
{
    public Transform ruchka;
    public ecran rej;
    private void OnMouseDown()
    {
        ruchka.transform.Rotate(0,0,-120);
        rej.steps--;
    }
}
