using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpawnerScript : MonoBehaviour
{
    public GameObject windPrefab;
    private GameObject wind;
    private AreaEffector2D areaEffector;
    private SpriteRenderer spriteRenderer;
    private Collider2D colliderBase;
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
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));

            wind = Instantiate(windPrefab, transform.position, Quaternion.identity);

            areaEffector = wind.GetComponent<AreaEffector2D>();

            areaEffector.forceMagnitude = Random.Range(minSpawnTime, maxSpawnTime);

            spriteRenderer = wind.GetComponent<SpriteRenderer>();

            colliderBase = wind.GetComponent<Collider2D>();

            int direction = Random.Range(0, 2);
            if (direction == 0)
            {
                areaEffector.forceAngle = 0;
                spriteRenderer.flipX = !spriteRenderer.flipX;
                colliderBase.offset = new Vector2(-colliderBase.offset.x, colliderBase.offset.y);
                wind.transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
            }
            else
            {
                areaEffector.forceAngle = 180;
            }
            



            yield return new WaitForSeconds(Random.Range(minLifetime, maxLifetime));

            Destroy(wind);
        }
        
    }
}
