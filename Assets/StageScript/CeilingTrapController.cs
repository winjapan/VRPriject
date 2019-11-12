using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingTrapController : MonoBehaviour
{
    public GameObject ceilingTrap;
    public Animator animator;

    public GameObject FallPoint;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("ceilingTrap").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            animator.enabled = true;
          }
    }
}
