using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    private float timer = 0;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 3){ //if timer is less than the spawn rate
            timer += Time.deltaTime; //timer counts up every frame rate 
        }

        else{
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe(){
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 15);
    }
}
