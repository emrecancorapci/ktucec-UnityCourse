using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;

    private float spawnPosition = 25;
    private float startDelay = 2;
    private float repeatRate = 3;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay,repeatRate);
    }

    void SpawnObstacle()
    {
        Instantiate(obstacle, Vector3.right * spawnPosition, transform.rotation);
    }
}
