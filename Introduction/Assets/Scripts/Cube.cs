using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float cubeSpeed;
    private Rigidbody rb;
    // private Vector3 ileri = new Vector3(2,0,0);
    // private Quaternion donme = Quaternion.Euler(360 * Mathf.Rad2Deg, 0, 0);

    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        // rb.mass = 50;
        
        // GameObject obje = GameObject.FindWithTag("Player");
        // obje.transform.position += Vector3.forward;
    }

    void Update()
    {
        // transform.position = transform.position + ileri * Time.deltaTime;
        // transform.rotation = transform.rotation * donme;
        rb.AddForce(Vector3.left * cubeSpeed);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            transform.localScale = transform.localScale * 100;
        }
    }
}
