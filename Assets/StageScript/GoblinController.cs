using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinController : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent agent;
    private Animator animator;
    private Rigidbody rgbody;

    public GoblinAttack gobAttack;
    // public bool IsKinematic;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        gobAttack = GetComponent<GoblinAttack>();
        rgbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
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

            gobAttack.enabled = true;

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

