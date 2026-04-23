using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float moveSpeed = 2f;
    public float minInterval = 2f;
    public float maxInterval = 5f;

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
        float randomY = Random.Range(2.5f, 4.5f);
        Vector3 spawnPos = new Vector3(12f, randomY, 0f);

        GameObject cloud = Instantiate(cloudPrefab, spawnPos, Quaternion.identity);
        cloud.GetComponent<Mover>().speed = moveSpeed;
    }
}
