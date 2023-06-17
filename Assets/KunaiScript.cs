using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -45;    // limite da esquerda da tela, para deletar as kunais

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Kunai Deleted");
            Destroy(gameObject);
        }

        // Time.deltaTime = o calculo fica igual independente do frame rate
    }
}
