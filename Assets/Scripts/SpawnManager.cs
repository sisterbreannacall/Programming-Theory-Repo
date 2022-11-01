using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2.0f;
    private float spawnRangeX = 8.4f;
    private float spawnInterval = 1.8f;
    [SerializeField] private List<GameObject> animalPrefabs;

    private void Start() 
    {
        if (GameManager.Instance.CheckGameStatus())
        {
            InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
        }
    }

    private void Update() 
    {
        if (!GameManager.Instance.CheckGameStatus())
        {
            CancelInvoke();
        }   
    }

    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Count);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, transform.position.z);
        Instantiate(animalPrefabs[animalIndex], spawnPos, transform.rotation);
    }
}
