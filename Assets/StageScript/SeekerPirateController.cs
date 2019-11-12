using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeekerPirateController : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent agent;
    private Animator animator;

    public SeekerPirateAttack spAttack;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        spAttack = GetComponent<SeekerPirateAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
        animator.SetBool("Walk",true);
    }

    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.enabled = false;
            spAttack.enabled = true;
            agent.enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
