using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 22;
    private float startDelay = 2;
    private float spawnInterval = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    //For spawning animals in our game
    void SpawnRandomAnimal(){
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0 ,spawnPosZ);
            int animalIndex  = Random.Range(0,animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex],spawnPos,animalPrefabs[animalIndex].transform.rotation);
    }
}
