using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical"); // * speed * Time.deltaTime;
        Vector3 movement;
        movement.x = x;
        movement.y = 0.0f;
        movement.z = y;

        gameObject.transform.Translate(movement * speed * Time.deltaTime);
    }
}
//if (Input.GetMouseButtonDown(0))
//{
//    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
//    RaycastHit hit;

//    if (Physics.Raycast(ray, out hit))
//    {
//        // MOVE CHARACTER 
//        agent.SetDestination(hit.point);
//    }
//}    
