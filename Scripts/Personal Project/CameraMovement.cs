using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSensitivity = 3.4f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         horizontalInput = Input.GetAxis("Mouse X");
        verticalInput = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up, cameraSensitivity * horizontalInput);
        transform.Rotate(Vector3.left, cameraSensitivity * verticalInput);

        transform.Rotate(Vector3.forward, -transform.localEulerAngles.z);
    }
}
