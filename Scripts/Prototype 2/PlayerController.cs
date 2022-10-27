using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float hSpeed = 20.0f;
    private float xRange = 20;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Time.deltaTime * hSpeed * horizontalInput * Vector3.right);
       
      //Range controller 
        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
        if(transform.position.x > xRange){
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        //KeyCode es para cualquier tecla
         if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch something
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
