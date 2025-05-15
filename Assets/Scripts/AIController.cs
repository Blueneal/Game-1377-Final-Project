using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Timeline;

public class AIController : MonoBehaviour
{
    [SerializeField] private Transform[] target;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private int currentTargetIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 0.00001f)
        {
            agent.SetDestination(target[currentTargetIndex++].position);
            if (currentTargetIndex == 8)
            {
                currentTargetIndex = 0;
            }
        }
    }
}
