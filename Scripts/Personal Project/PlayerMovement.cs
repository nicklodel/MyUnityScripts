using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     private float moveHorizontal;
    private float moveVertical;
    private float horizontalInput;
    private float jump;
    private float speed = 8.0f;
    private float jumpForce = 9.0f;
    private float sensitivity = 3.4f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");
        horizontalInput = Input.GetAxis("Mouse X");
            

        
        transform.Translate(Vector3.up * Time.deltaTime * jump * jumpForce);
        transform.Translate(Vector3.forward *  speed * Time.deltaTime * moveVertical);
        transform.Rotate(Vector3.up, sensitivity  * horizontalInput);
        transform.Rotate(Vector3.right, sensitivity  * 0.0f);
        transform.Translate(Vector3.right * speed * Time.deltaTime * moveHorizontal);
    }
}
