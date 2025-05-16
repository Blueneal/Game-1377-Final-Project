using UnityEngine;

public class RandomObstacles : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    private float startDelay = 3;
    private float spawnCooldown = 2.0f;

    public int spawnX;
    public float spawnY;
    public int spawnZ;

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
        Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(spawnX, spawnY, spawnZ), obstaclePrefabs[obstacleIndex].transform.rotation);
    }
}
