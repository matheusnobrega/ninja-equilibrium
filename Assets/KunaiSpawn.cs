using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject Kunai;
    public float spawnRate = 4;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnKunai();
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
            spawnKunai();
            timer = 0;
        }


    }

    void spawnKunai()
    {

        Instantiate(Kunai, new Vector3(transform.position.x, transform.position.y, 0)
            , transform.rotation);

        // new Vector3 = necess�rio quando vou colocar meus n�meros no vetor
        // transform.position.x = spawna em cima do spawner
    }
}
