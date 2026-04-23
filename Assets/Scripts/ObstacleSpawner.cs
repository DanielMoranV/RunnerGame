using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float moveSpeed = 5f;
    public float minInterval = 1.5f;
    public float maxInterval = 3.5f;
    public float spawnY = -3.5f;

    private float timer;
    private float nextSpawn;

    void Start()
    {
        nextSpawn = Random.Range(minInterval, maxInterval);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= nextSpawn)
        {
            Spawn();
            timer = 0f;
            nextSpawn = Random.Range(minInterval, maxInterval);
        }
    }

    void Spawn()
    {
        Vector3 spawnPos = new Vector3(12f, spawnY, 0f);

        GameObject obstacle = Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
        obstacle.GetComponent<Mover>().speed = moveSpeed;
    }
}
