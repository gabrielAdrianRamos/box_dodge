using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBoxSpawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float spawnInterval = 2f;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval) {
            float spawnX = Random.Range(transform.position.x - 2.8f, transform.position.x + 2.8f);
            Vector3 spawnPosition = new Vector3(spawnX, 6f, 0f);

            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

            timer = 0f;
        }
    }
}
