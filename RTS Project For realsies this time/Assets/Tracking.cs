using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Tracking : MonoBehaviour {
    private Object target;
    public float range = 5f;
    public SpawnWave spawn;
    List<Object> list;
    public Movement movement;
    void Start()
    {
        list = spawn.GetlistClone();
    }
    public void FindEnemy()
    {
        float Min_distance = 1000;
        for (int i = 0; i < list.Count; i++)
            {
                GameObject var1 = list[i] as GameObject;
                float New_distance = (transform.position - var1.transform.position).magnitude;
                if (New_distance <= Min_distance)
                {
                    Min_distance = New_distance;
                    target = list[i];
                }

            }
    }
    void Update()
    {
        if (target == null)
        {
            FindEnemy();
        }
        GameObject var1 = target as GameObject;
        if (target == null)
        {
            return;
        }
        else
        {
            float dist = (transform.position - var1.transform.position).magnitude;
            //print(dist);
            if (range < dist)
            {
                target = null;
            }
            else
            {
                GameObject target1 = target as GameObject;
                transform.LookAt(target1.transform);
                //Destroy(target1);
                //movement.Shoot();
            }
        }

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
