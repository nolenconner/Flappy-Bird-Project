using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D RigidBody; //access the velocity to go up
    public float Strength; //higher the number, more bouncy the bird is 
    public LogicScript logic; //calling to logic class
    public bool isAlive = true; //sees if bird is alive

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space) && isAlive){
            RigidBody.velocity = Vector2.up * Strength; //goes up everytime space is clicked and bird is alive
        }
    }

     void OnCollisionEnter2D(Collision2D col){ //dies and game over when collides with object
            isAlive = false;
            logic.gameOver();
        }        
    }


    

