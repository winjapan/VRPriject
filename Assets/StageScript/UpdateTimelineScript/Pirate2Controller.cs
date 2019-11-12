using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pirate2Controller : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent agent;
    private Animator animator;

    public Pirate2Attack pAttack2;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        pAttack2 = GetComponent<Pirate2Attack>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
        animator.SetBool("Run", true);
    }

    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {

            GetComponent<Rigidbody>().isKinematic = true;
            agent.enabled = false;
            pAttack2.enabled = true;
            this.enabled = false;
        }
    }
}

