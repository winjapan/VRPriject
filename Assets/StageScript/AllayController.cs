using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AllayController : MonoBehaviour
{
     public GameObject target;

    private NavMeshAgent agent;
    private Animator animator;
    private Rigidbody rgbody;

    public AllayAttack allay;

    //   public float walkTime = 20;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rgbody = GetComponent<Rigidbody>();
        allay = GetComponent<AllayAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
        animator.SetBool("walk", true);
        //        Debug.Log("Move");
        // print(agent.hasPath);
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "LastBoss")
        {
            animator.SetBool("walk", false);

            this.enabled = false;
            agent.enabled = false;
            allay.enabled = true;
            GetComponent<Rigidbody>().isKinematic = true;
       
        }
    }
}
