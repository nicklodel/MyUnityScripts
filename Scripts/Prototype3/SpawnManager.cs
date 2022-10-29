using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(18,0,5.7f);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerMovement playerControllerScript;
    
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnObstacle(){
       if(playerControllerScript.gameOver == false){
       Instantiate(obstaclePrefab, spawnPos,obstaclePrefab.transform.rotation); 
       }
    }
}
