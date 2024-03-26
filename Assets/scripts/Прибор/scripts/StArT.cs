using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StArT : MonoBehaviour
{

    public GameObject gm;
    public TextMesh dislpay;
    private void OnMouseDown()
    {
        if (gm.activeSelf)
        {
            gm.SetActive(false);
            dislpay.text = "8.8.8.8";
        }
        else 
        {
            gm.SetActive(true);
        }
    }

    
}
