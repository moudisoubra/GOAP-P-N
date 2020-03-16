using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject patient;
    public int patients;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < patients; i++)
        {
            Instantiate(patient, transform.position, Quaternion.identity);
        }

        Invoke("SpawnPatients", 5);
    }

    void SpawnPatients()
    {
        Instantiate(patient, transform.position, Quaternion.identity);
        Invoke("SpawnPatients", Random.Range(2, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
