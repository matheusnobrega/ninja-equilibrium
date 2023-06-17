/*
using UnityEngine;

public class ControlePilar : MonoBehaviour
{

    public Rigidbody2D rb;
    public float leftLimit = 0.3f;
    public float rightLimit = 0.3f;
    public float speed;

void Start()
    { 
    rb = GetComponent<Rigidbody2D>();
    rb.angularVelocity = 500;
}

void Update()
    {
        swingMove();


    }
void swingMove()
    {
        if(transform.rotation.z < rightLimit && rb.angularVelocity > 0 && rb.angularVelocity < speed)
        {
            rb.angularVelocity = speed;
        }

        else if (transform.rotation.z > leftLimit && rb.angularVelocity < 0 && rb.angularVelocity > -speed)
        {
            rb.angularVelocity = -speed;
        }
    }
}
*/