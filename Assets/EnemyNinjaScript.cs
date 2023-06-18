using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;


public class EnemyNinjaScript : MonoBehaviour
{
    public float moveSpeed = 30;
    public float deadZone = 45;    // limite da esquerda da tela, para deletar as kunais
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update ()
    {

        
         transform.position += (Vector3.right * moveSpeed) * Time.deltaTime;


         if (transform.position.x > deadZone)
         {
             Debug.Log("Enemy Ninja Deleted");
             Destroy(gameObject);
                
         }
        

        // Time.deltaTime = o c�lculo fica igual independente do frame rate
    }


}
