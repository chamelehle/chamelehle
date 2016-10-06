using UnityEngine;
using System.Collections;

public class moveDestination : MonoBehaviour
{
    public Transform goal;
    void start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        
    }
    /*
    NavMeshAgent agent;
    GameObject obj;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(obj.transform.position);
    }
    void Update()
    {
        agent.SetDestination(obj.transform.position);
    }
    */
}