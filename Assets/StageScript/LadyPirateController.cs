using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class LadyPirateController : MonoBehaviour
{
    public GameObject target;

    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody rgbody;

    public LadyPirateAttack lady;

 //   public float walkTime = 20;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        //rgbody = GetComponent<Rigidbody>();
        lady = GetComponent<LadyPirateAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
        animator.SetBool("walk",true);
//        Debug.Log("Move");
       // print(agent.hasPath);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("walk", false);
            this.enabled = false;
            agent.enabled = false;
            lady.enabled = true;
            GetComponent<Rigidbody>().isKinematic = true;
//            Debug.Log("Move");
        }
    }

}
