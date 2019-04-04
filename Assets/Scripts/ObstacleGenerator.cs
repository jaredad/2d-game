using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public ObjectPooler obstaclePool;
    public float distanceBetweenObstacles;

    public void SpawnObstacles(Vector3 startPosition)
    {
        GameObject obstacle = obstaclePool.getPooledObject();
        obstacle.transform.position = startPosition;
        obstacle.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
