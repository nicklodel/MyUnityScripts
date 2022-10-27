using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    //Private variables for security
    private float speed = 11.0f;
    private float turnSpeed = 10.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input received for movement
        verticalInput = Input.GetAxis("Vertical"); 
        horizontalInput = Input.GetAxis("Horizontal");

        //Movement made real :)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime *turnSpeed);
    }
}
