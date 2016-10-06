using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SpawnWave : MonoBehaviour {
    public GameObject enemy;
    public float spawnInterval = 3f;
    public Transform spawnPoint;
    List<Object> listClones;
    public Transform goal;
    void Start()
    {
        listClones = new List<Object>();
        InvokeRepeating("Spawn", spawnInterval, spawnInterval);
    }
    void Spawn()
    {
        Object new_clone = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        GameObject new_obj = new_clone as GameObject;
        Movement Variable = new_obj.GetComponent<Movement>();
        Variable.SetGoal(goal);
        listClones.Add(new_clone);
    }
    public List<Object> GetlistClone ()
    {
        return listClones;
    }
}