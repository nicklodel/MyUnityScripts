using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 14;
    private float leftBound = 80;
    // Communication between scripts
    private PlayerMovement playerControllerScript;
    void Start()
    {
        //Point at a certain script from an object
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //It actually moves left, just a cuestion of perspective ;)
        if(playerControllerScript.gameOver == false){
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    
        if(transform.position.x > leftBound && gameObject.CompareTag("Obstacle")){
        Destroy(gameObject);
    }
        
    }
}
