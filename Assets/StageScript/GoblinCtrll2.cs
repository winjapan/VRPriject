using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinCtrll2 : MonoBehaviour
{

    public GameObject target;

    private NavMeshAgent agent;
    private Animator animator;
    private Rigidbody rgbody;

    public GoblinAttack2 attack2;
    // public bool IsKinematic;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        attack2 = GetComponent<GoblinAttack2>();
        rgbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        agent.destination = target.transform.position;
        animator.SetBool("run", true);
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("run", false);
            this.enabled = false;
            agent.enabled = false;

            GetComponent<Rigidbody>().isKinematic = true;

            attack2.enabled = true;

        }

        if (other.gameObject.tag == "Gob")

        {
            animator.SetBool("run", false);
            this.enabled = false;
            agent.enabled = false;

            GetComponent<Rigidbody>().isKinematic = true;


        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Gob")
        {
            this.enabled = true;
            agent.enabled = true;

            GetComponent<Rigidbody>().isKinematic = true;


        }
    }
}
