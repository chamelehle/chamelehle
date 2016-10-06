using UnityEngine;
using System.Collections;

public class RandomPlacement : MonoBehaviour
{

    public GameObject Turret;
    public Vector3 spawnSpot = new Vector3(0, 1, 0);

    void Start()
    {
        GameObject TurretSpawn = (GameObject)Instantiate(Turret, new Vector3(0, 1, 0), transform.rotation);
    }
}
