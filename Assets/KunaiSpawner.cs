using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiSpawner : MonoBehaviour
{

    public GameObject Kunai;
    public float timer = 0;
    public int spawnRate = 10;


    private void Update()
    {
        
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnKunai();
            timer = 0;
        }
    }
    public void spawnKunai()
    {

        Instantiate(Kunai, new Vector3(transform.position.x, transform.position.y, 0)
            , transform.rotation);
        spawnRate = Random.Range(5, 15);

        // new Vector3 = necess�rio quando vou colocar meus n�meros no vetor
        // transform.position.x = spawna em cima do spawner
    }
}
