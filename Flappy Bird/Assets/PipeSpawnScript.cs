using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 4){ //if timer is less than the spawn rate
            timer += Time.deltaTime; //timer counts up every frame rate 
        }

        else{
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe(){
        float high = transform.position.y + 12;
        float low = transform.position.y - 12; //height offset
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(low, high), 0), transform.rotation);
    }
}
