using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //REmove object out of bounds
        if(transform.position.z > topBound){
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound){
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
