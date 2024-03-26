using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rejimi : MonoBehaviour
{
    public int steps;

    private void Update()
    {
        if (steps == 4)
        {
            steps = 1;
        }
        else if (steps == 0)
        {
            steps = 3;
        }
    }
}
