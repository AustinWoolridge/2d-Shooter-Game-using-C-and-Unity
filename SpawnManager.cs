using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, 3);
        Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-10, 11), 0f, 20f), animalPrefabs[animalIndex].transform.rotation);
    }
}
