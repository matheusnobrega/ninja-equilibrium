using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaPoseScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite poseReto;
    public Sprite poseCaindo;
    public GameObject character;
    public int lado = 0;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = poseReto;
    }

    // Update is called once per frame
    void Update()
    {
        if(character.transform.position.x <= -2.3)
        {
            spriteRenderer.sprite = poseCaindo;
            if (lado == 1)
            {
                spriteRenderer.flipX = !spriteRenderer.flipX;
                lado = 0;
            }
            tamanho(0);


        }
        else if(character.transform.position.x >= 2.3)
        {
            spriteRenderer.sprite = poseCaindo;
            if (lado == 0)
            {
                spriteRenderer.flipX = !spriteRenderer.flipX;
                lado = 1;
            }
            tamanho(1);
        }
        else
        {
            spriteRenderer.sprite = poseReto;
            spriteRenderer.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    void tamanho(int lado)
    {
        spriteRenderer.transform.localScale = new Vector3(2f, 2f, 2f);
        
    }
}
