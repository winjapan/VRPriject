using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrollController : MonoBehaviour
{
    public GameObject target;
   // public AudioClip Ex;
    public float atkTime = 15;
    private Animator animator;
    private Collider maceCol;
    private AudioSource audioSource;

    public GameObject ShockWave;
    private int waveCount;

    bool isSound = false;

   

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        maceCol = GameObject.Find("mace_low").GetComponent<SphereCollider>();
        audioSource = GetComponent<AudioSource>();
       
        maceCol.enabled = true;
       
        atkTime = 15;
    }

    // Update is called once per frame
    void Update()
    {
        atkTime -= Time.deltaTime;

        if (atkTime < 15)
        {
            animator.SetBool("attack1 1", true);

           
        }

        if (atkTime <14)
        {
            animator.SetBool("attack1 1", false);
       
        }

      

        if (atkTime < 9)
        {
            animator.SetBool("attack2 0", true);
        }

        if (atkTime < 8)
        {
            animator.SetBool("attack2 0", false);
        }

      
        if (atkTime < 3)
        {
            animator.SetBool("attack2 0", true);
        }

        if (atkTime < 2)
        {
            animator.SetBool("attack2 0", false);
        }

        if (atkTime <0) 
        {

            Start(); 
        }

    }

}
