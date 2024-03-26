using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    float distance = 3;
    public Transform pos;
    private Rigidbody rb;
    private void Start()
    {

        rb =  GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, distance))
        {
            rb.isKinematic = true;
            rb.MovePosition(pos.position);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.isKinematic == true)
        {
            this.gameObject.transform.position = pos.position;
            if (Input.GetKey(KeyCode.G))
            {
                rb.useGravity = true;
                rb.isKinematic = false;
                rb.AddForce(Camera.main.transform.forward * 500);
            }
        }
    }
}
