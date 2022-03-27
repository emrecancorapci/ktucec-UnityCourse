using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    public float repeatPos;
    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        if (transform.position.x < startPosition.x - repeatPos)
        {
            transform.position = startPosition;
        }
    }
}
