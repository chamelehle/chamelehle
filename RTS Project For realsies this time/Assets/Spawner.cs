using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;                
    public float spawnInterval = 3f;           
    public Transform spawnPoint;        
    

    void Start()
    {
        InvokeRepeating("Spawn", spawnInterval, spawnInterval);
    }


    void Spawn()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}