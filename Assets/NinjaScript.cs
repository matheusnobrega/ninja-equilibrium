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
    public bool ninjaIsAlive = true;
    public GameObject Base;
    public float jumpStrength;
    public Rigidbody2D myRigidBody;
    public TimerScript timer;
    public AudioSource caindooo;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        hingeJointBase = GetComponent<HingeJoint2D>();
        connectedBody = hingeJointBase.connectedBody;
        //timer = GetComponent<TimerScript>();
    }


    void Update()
    {
        rotationInput = Input.GetAxis("Horizontal");
        if (ninjaIsAlive)
        {
            if (rotationInput != 0)
            {
                float targetAngularVelocity = (-1) * rotationInput * rotationSpeed;   // Movimentação do personagem

                GetComponent<Rigidbody2D>().angularVelocity = targetAngularVelocity;
            }
            else
            {
                GetComponent<Rigidbody2D>().angularVelocity = 0f;
            }

            //if (Input.GetKeyDown(KeyCode.Space) == true)
            //{
            //    myRigidBody.velocity = Vector2.up * jumpStrength;
            //}

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Left" || collision.gameObject.name == "Right")
        {
            caindooo.Play();
            EndGame();
        }
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Kunai(Clone)")
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        logic.gameOver();
        ninjaIsAlive = false;
        Base.SetActive(false);
        timer.stopTimer();
    }
}
