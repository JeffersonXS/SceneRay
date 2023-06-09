using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject Inimigo;
    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-20f, 20f), 1, Random.Range(-0.8f, 50f));
        Instantiate(Inimigo, randomSpawnPosition, Quaternion.identity);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && raycast.Atirado){
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-20f, 20f), 1, Random.Range(-0.8f, 50f));
            Instantiate(Inimigo, randomSpawnPosition, Quaternion.identity);
        }
    }
}