using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dummy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = dummy.transform.position + new Vector3(0,1.8f,0);
    }
}
