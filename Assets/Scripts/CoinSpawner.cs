using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 2.5f;
    public float spawnX = 10f;
    public float spawnY = -1.5f;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
       ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnCoin();
            ResetTimer();
        }
    }

    void SpawnCoin()
    {
        Vector3 spawnPos = new Vector3(spawnX, spawnY, 0f);

        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }

    void ResetTimer()
    {
        timer = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
