using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject laserPrefab;
    public GameObject bombPrefab;

    public float spawnRate = 1.5f;
    public float xSpawn = 10f;
    public float yRange = 4f;

    void Start()
    {
        InvokeRepeating("Spawn", 1f, spawnRate);
    }

    void Spawn()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-yRange, yRange);

        Vector3 pos = new Vector3(x, y, 0);
        Instantiate(laserPrefab, pos, Quaternion.identity);
        Instantiate(bombPrefab, pos, Quaternion.identity);
    }
}