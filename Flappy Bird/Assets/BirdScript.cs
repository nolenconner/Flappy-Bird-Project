using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D RigidBody; //access the velocity to go up
    public float Strength; //higher the number, more bouncy the bird is 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space) == true){
            RigidBody.velocity = Vector2.up * Strength; //goes up everytime space is clicked
        }
    }
}
