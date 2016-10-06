using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Movement : MonoBehaviour
{
    //private Object target;
    //List<Object> list;
    private Transform goal;
    private bool has_goal = false;
    public int health = 100;
    /*public void Shoot()
    {
        Find();
        GameObject target1 = target as GameObject;
        Destroy(target1);
        return;   
    }
    
    public void Find()
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
    */
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        has_goal = false;
    }
    void Update()
    {
        if(goal && has_goal == false)
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = goal.position;
            has_goal = true;
        }
    }
    public void SetGoal(Transform new_goal)
    {
        goal = new_goal;
    }
}