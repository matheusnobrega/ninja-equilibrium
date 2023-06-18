using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaScript : MonoBehaviour
{
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }


    void Update()
    {
        // adicionar lógica de movimento do boneco
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Left" || collision.gameObject.name == "Right")
        {
            logic.gameOver();
        }
            
    }
}
