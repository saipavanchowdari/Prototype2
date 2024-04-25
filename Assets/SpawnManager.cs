using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    private float spwax = 20;
    private float spwaz = 20;
    private float startDelay = 2f;
    private float interval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, interval);
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void SpawnRandomAnimal()
    {
        Vector3 spwapos = new Vector3(Random.Range(-spwax, spwax), 0, spwaz);
        int index = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[index], spwapos, animalPrefabs[index].transform.rotation);
    }
}
