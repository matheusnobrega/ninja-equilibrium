using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaScript : MonoBehaviour
{
    public LogicScript logic;
    public HingeJoint2D hingeJointBase;
    public float rotationSpeed = 1000f;
    private float rotationInput;
    public float clockwiseRotationSpeed = 1f;
    public float counterclockwiseRotationSpeed = 1f;
    private Rigidbody2D connectedBody;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        hingeJointBase = GetComponent<HingeJoint2D>();
        connectedBody = hingeJointBase.connectedBody;
    }


    void Update()
    {
        rotationInput = Input.GetAxis("Horizontal");

        if (rotationInput != 0)
        {
            float targetAngularVelocity = rotationInput * rotationSpeed;

            GetComponent<Rigidbody2D>().angularVelocity = targetAngularVelocity;
        }
        else
        {
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Left" || collision.gameObject.name == "Right")
        {
            logic.gameOver();
        }
            
    }
}
