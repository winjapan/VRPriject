using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LPPointMove : MonoBehaviour
{
    public GameObject AllayPoint;
    private NavMeshAgent agent;
    private Rigidbody rgbody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        rgbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = AllayPoint.transform.position;
        animator.SetBool("walk",true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "AllyPoint")
        {
            GameObject.Find("Lady Pirate Ally").GetComponent<NavMeshAgent>().enabled = false;
            this.enabled = false;
        
        animator.SetBool("walk",false);
        }
    }
}
