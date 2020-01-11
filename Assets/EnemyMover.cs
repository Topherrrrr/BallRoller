using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    float speed = .1f;
    NavMeshAgent agent;
    public bool tracking;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tracking)
        {
            agent.SetDestination(Basics.Player.transform.position);
        }
    }

  
}
