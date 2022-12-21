using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Movement : MonoBehaviour
{
    public Camera camera;
    private Animator animation;

    private RaycastHit hit;
    private NavMeshAgent agent;

    private Vector3 pos;

    private string groundTag ="Ground";
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        pos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (pos != transform.position) 
        {
            animation.Play("walking", 0, -1);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray =camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.CompareTag(groundTag))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
       
}