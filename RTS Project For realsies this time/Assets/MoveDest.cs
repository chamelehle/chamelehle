using UnityEngine;
using System.Collections;

public class moveDest : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject obj;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.SetDestination(obj.transform.position);
    }
}