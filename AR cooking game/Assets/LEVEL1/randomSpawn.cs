using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class randomSpawn : MonoBehaviour
{
    //GameObject[] Ingredients; 
    public GameObject lettuce;
    public GameObject ham;
    public GameObject cheese;

    public List<GameObject> FOODLIST = new List<GameObject>();

    private GameObject randomfood;
    public float spawnRate;


    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnRate);
    }

    public GameObject cubePrefab;

    void Update()
    {
        randomfood = FOODLIST[Random.Range(0, FOODLIST.Count - 1)];

    }

    void Spawn()
    {
        Vector3 randomSpawnPosition = new Vector3(UnityEngine.Random.Range(-10, 21), 10, UnityEngine.Random.Range(-10, 21));
        Instantiate(randomfood, randomSpawnPosition, Quaternion.identity);

        
    }
}

