using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp : MonoBehaviour
{
    public Light Lamp;
    public buttonscheme button;
    public rezistor rez;
    public battery batt;
    public float silatoka;
    [Range(1f, 10f)]
    public float soprotivleniye = 1f;
    public GameObject klemma1, klemma2;
    public ecran ec;
    private void Update()
    {
        silatoka = batt.napryajeniye / rez.soprotivleniye;

        if (button.step==true)
        {
            Lamp.intensity = silatoka;
        }
        else if (button.step == false)
        {
            Lamp.intensity = 0f;
        }
    }

    private void OnMouseDown() 
    {
        klemma1.transform.position = transform.position;
        klemma1.transform.position = transform.position + new Vector3(0.2f, 0.3f, 2f);
        klemma2.transform.position = transform.position;
        klemma2.transform.position = transform.position + new Vector3(0.2f, 0.3f, -2f);
        ec.rejims = 0;
        ec.klems = true;
    }
}
