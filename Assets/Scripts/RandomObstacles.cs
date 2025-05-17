using UnityEngine;

public class RandomObstacles : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    private float startDelay = 3;
    private float spawnCooldown = 2.0f;

    //gives flexible spawn position for prefabs for the individual spawners
    public int spawnX;
    public float spawnY;
    public int spawnZ;

    public PlayerMover playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnCooldown);
    }

    // checks to see if player is dead, and destroys spawner if true
    void Update()
    {
        if (playerController.isPlayerDead)
        {
            Destroy(gameObject);
        }
    }

    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(spawnX, spawnY, spawnZ), obstaclePrefabs[obstacleIndex].transform.rotation);
    }
}
