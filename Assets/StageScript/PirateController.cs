using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PirateController : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent agent;
    private Animator animator;

    public PirateAttack pAttack;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        pAttack = GetComponent<PirateAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
        animator.SetBool("Run",true);
    }

    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
           
            GetComponent<Rigidbody>().isKinematic = true;
            agent.enabled = false;
            pAttack.enabled = true;
            this.enabled = false;
        }
    }
}
