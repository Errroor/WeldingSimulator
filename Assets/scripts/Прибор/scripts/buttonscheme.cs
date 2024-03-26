using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonscheme : MonoBehaviour
{
    public bool step = false;
    private void OnMouseDown()
    {
        if (!step) 
        {
            this.transform.Rotate(0, 0, 45);
            step = true;
        }
        else if (step)
        {
            this.transform.Rotate(0, 0, -45);
            step = false;
        }
    }
}
