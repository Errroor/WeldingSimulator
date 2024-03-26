using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rezistor : MonoBehaviour
{
    [Range(1f,1000f)] 
    public float soprotivleniye = 1f;
    public GameObject klemma1, klemma2;
    public ecran ec;
    private void OnMouseDown()
    {
        klemma1.transform.position = transform.position;
        klemma1.transform.position = transform.position + new Vector3(0f, -0.8f, 2f);
        klemma2.transform.position = transform.position;
        klemma2.transform.position = transform.position + new Vector3(0f, -0.8f, -2f);
        ec.rejims = 1;
        ec.klems = true;
    }
}
