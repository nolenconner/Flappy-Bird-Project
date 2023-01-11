using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * 5) * Time.deltaTime; //changing the postiton of the pipes
        //Vector3 uses the Z coordinate so pipes will be aligned, 5 is the move speed of the pipe
                    Debug.Log("test");

        if (transform.position.x < -45){
            Debug.Log("deleted");
            Destroy(gameObject);
        }
    }
}
