using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnerManagerScript : MonoBehaviour
{

    public KunaiSpawner kunaiSpawner; // scipt pra spawnar kunais
    public WindSpawnerScript windSpawner;
    public float timer = 0;
    public int spawnRate = 10;

    // Start is called before the first frame update
    void Start()
    {
        kunaiSpawner = GameObject.FindGameObjectWithTag("KunaiSpawn").GetComponent<KunaiSpawner>();
        windSpawner = GameObject.FindGameObjectWithTag("WindSpawn").GetComponent<WindSpawnerScript>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            kunaiSpawner.spawnKunai();
            timer = 0;
        }

    }

   
}
