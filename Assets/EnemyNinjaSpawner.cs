﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class EnemyNinjaSpawner : MonoBehaviour
{
    public GameObject EnemyNinja;
    public float timer = 0;
    public int spawnRate = 25;
    


    private void Start()
    {
        
    }
    private void Update()
    {
        
            if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnNinja();
            timer = 0;
        }
    }
    public void spawnNinja()
    {

        Instantiate(EnemyNinja, new Vector3(transform.position.x, transform.position.y, 0)
            , transform.rotation);
        //if (TempoJogo.text <= 60)
        

        
        spawnRate = Random.Range(20, 30);

        // new Vector3 = necess�rio quando vou colocar meus n�meros no vetor
        // transform.position.x = spawna em cima do spawner
    }

}
