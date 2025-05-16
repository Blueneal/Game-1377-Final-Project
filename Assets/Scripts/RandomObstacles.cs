using UnityEngine;

public class RandomObstacles : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    //public GameObject[] spawnPoints;

    private float startDelay = 3;
    private float spawnCooldown = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnCooldown);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        //int spawnIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(-7, 8, 51), obstaclePrefabs[obstacleIndex].transform.rotation);
    }
}
