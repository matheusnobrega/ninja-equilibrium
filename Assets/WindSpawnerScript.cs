using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpawnerScript : MonoBehaviour
{
    public GameObject windPrefab;
    private GameObject wind;
    private AreaEffector2D areaEffector;
    public float minSpawnTime = 5f;
    public float maxSpawnTime = 15f;
    public float minMagnitude = 1f;
    public float maxMagnitude = 10f;
    public float minLifetime = 1f;
    public float maxLifetime = 5f;
    public float destroyDelay = 5f;

    private void Start()
    {
        StartCoroutine(SpawnObject());

    }

    private IEnumerator SpawnObject()
    {
        while (true)
        {
            wind = Instantiate(windPrefab, transform.position, Quaternion.identity);

            areaEffector = wind.GetComponent<AreaEffector2D>();

            areaEffector.forceMagnitude = Random.Range(minSpawnTime, maxSpawnTime);

            // Generate a random number between 0 and 1
            //            int randomNumber = Random.Next(0, 2);
            areaEffector.forceAngle = Random.Range(minLifetime, maxLifetime);

            yield return new WaitForSeconds(Random.Range(minLifetime, maxLifetime));

            Destroy(wind);

            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        }
        
    }
}
