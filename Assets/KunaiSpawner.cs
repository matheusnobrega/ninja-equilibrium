using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject Kunai;
    

    public void spawnKunai()
    {

        Instantiate(Kunai, new Vector3(transform.position.x, transform.position.y, 0)
            , transform.rotation);

        // new Vector3 = necess�rio quando vou colocar meus n�meros no vetor
        // transform.position.x = spawna em cima do spawner
    }
}
