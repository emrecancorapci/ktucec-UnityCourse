using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Cube cube;
    void Start()
    {
        cube = FindObjectOfType<Cube>();
        cube.cubeSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 5 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 5 * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation *= Quaternion.Euler(0,0,20);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation *= Quaternion.Euler(0,0,-20);
        }
    }
}
