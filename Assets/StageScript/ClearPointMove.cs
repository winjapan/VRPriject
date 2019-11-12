using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClearPointMove : MonoBehaviour
{
    public GameObject AllayPoint;
    private NavMeshAgent agent;
    private Rigidbody rgbody;
    private Animator animator;

    public GameObject Player;

   
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
        animator.SetBool("walk", true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Clear")
        {
            GameObject.Find("Lady Pirate Ally").GetComponent<NavMeshAgent>().enabled = false;
            GameObject.Find("Lady Pirate Ally").GetComponent<ClearPointMove>().enabled = false;

            animator.SetBool("walk", false);
            this.transform.LookAt(Player.transform);
            GameObject.Find("GameDirector").GetComponent<ClearEventAllay>().enabled = true;
        }
    }
}
