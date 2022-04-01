using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    Vector3 playerPosition;
    public GameObject player;
    public GameObject sightBox;
    public NavMeshAgent agent;

    private State state;

    private bool patrolling = true;
    private bool searching = false;
    private bool attacking = false;
    private bool retreating = false;

    public enum State
    {
        patrolling,
        chasing,
        searching,
        attacking,
        retreating
    }

    //IEnumerator PatrollingState()
    //{
    //    Debug.Log("Patrol: Enter");
    //    while (state == State.patrolling)
    //    {
    //        yield return 0;
    //    }
    //    Debug.Log("Crawl: Exit");

    //}

    //IEnumerator ChasingState()
    //{
    //    Debug.Log("Chase: Enter");
    //    while (state == State.chasing)
    //    {
    //        agent.SetDestination(playerPosition);
    //        yield return 0;
    //    }
    //    Debug.Log("Chase: Exit");
    //}

    // Start is called before the first frame update
    void Start()
    {
        state = State.patrolling;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position;

        if (sightBox.GetComponent<chaseTrigger>().chasing == true)
        {
            state = State.chasing;
        }
    }
}
