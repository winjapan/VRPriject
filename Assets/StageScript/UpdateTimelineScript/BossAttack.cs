using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossAttack : MonoBehaviour
{
    public GameObject target;

    public AudioClip Punch;

    private Animator animator;
    private AudioSource audioSource;
    public CowBoyController cowBoy;
    private NavMeshAgent agent;

    private Collider cowRPCol;
    private Collider cowLPCol;
    private Collider cowRFCol;
    private Collider cowLFCol;

    private float phAttackTime = 0.1f;

    public float nextwaitTime = 2f;
    public int playerRPATK = 10;

    public bool One;

    public float totalAttackTime;
  //  public Image sk2Fill;
    // Start is called before the first frame update
    void Start()
    {

       
        //startTime = Time.time;
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        cowBoy = GetComponent<CowBoyController>();
        agent = GetComponent<NavMeshAgent>();

        cowRPCol = GameObject.Find("d Hand").GetComponent<SphereCollider>();
        cowLPCol = GameObject.Find("L Hand").GetComponent<SphereCollider>();
        cowRFCol = GameObject.Find("R Foot").GetComponent<SphereCollider>();
        cowLFCol = GameObject.Find("L Foot").GetComponent<SphereCollider>();

        totalAttackTime = 20;
        One = false;

    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        animator.SetBool("move", false);
      
        totalAttackTime -= Time.deltaTime;

        if (totalAttackTime < 18)
        {
            animator.SetBool("Punch",true);
            GameObject.Find("SEManager").GetComponent<AudioSource>().enabled = true;
            One = true;
            cowRPCol.enabled = true;
            Debug.Log("17");
        }

        if (totalAttackTime < 17)
        {
            animator.SetBool("Punch", false);
            GameObject.Find("SEManager").GetComponent<AudioSource>().enabled = false;
            cowRPCol.enabled = false;
            One = false;
            Debug.Log("17");
        }

        if (totalAttackTime < 15)
        {
            animator.SetBool("Fook", true);
            GameObject.Find("SEManager2").GetComponent<AudioSource>().enabled = true;
            cowLPCol.enabled = true;
            One = true;

            Debug.Log("15");
        }

        if (totalAttackTime < 14)
        {
            animator.SetBool("Fook", false);
            GameObject.Find("SEManager2").GetComponent<AudioSource>().enabled = false;
            cowLPCol.enabled = false;
            One = false;
            Debug.Log("14");
        }

        if (totalAttackTime < 12)
        {
            animator.SetBool("upper", true);
            GameObject.Find("SEManager3").GetComponent<AudioSource>().enabled = true;
            cowRPCol.enabled = true;
            One = true;
            Debug.Log("12");
        }

        if(totalAttackTime < 11.5f)
        {
            cowRPCol.enabled = false;
        }

        if (totalAttackTime < 11)
        {
            animator.SetBool("upper", false);
            GameObject.Find("SEManager3").GetComponent<AudioSource>().enabled = false;
          
            One = false;
            Debug.Log("11");
        }

        if (totalAttackTime < 9)
        {
            animator.SetBool("Kick", true);
            GameObject.Find("SEManager4").GetComponent<AudioSource>().enabled = true;
            cowRFCol.enabled = true;
            One = true;
            Debug.Log("9");
        }

        if (totalAttackTime < 8)
        {
            animator.SetBool("Kick", false);
            GameObject.Find("SEManager4").GetComponent<AudioSource>().enabled = false;
            cowRFCol.enabled = false;
            One = false;
            Debug.Log("7");
        }

        if (totalAttackTime < 6)
        {
            animator.SetBool("Punch", true);
            GameObject.Find("SEManager6").GetComponent<AudioSource>().enabled = true;
            cowRPCol.enabled = true;
            One = true;
            Debug.Log("6");
        }

        if (totalAttackTime < 5.5f)
        {
            cowRPCol.enabled = false;
        }

        if (totalAttackTime < 5)
        {
            animator.SetBool("Punch", false);
            GameObject.Find("SEManager6").GetComponent<AudioSource>().enabled = false;
         
            One = false;
            Debug.Log("5");
        }

        if (totalAttackTime < 3)
        {
            animator.SetBool("FinalAttack", true);
            GameObject.Find("SEManager5").GetComponent<AudioSource>().enabled = true;
            cowLFCol.enabled = true;
            One = true;
            Debug.Log("3");
        }

        if (totalAttackTime < 1)
        {
            animator.SetBool("FinalAttack", false);
            GameObject.Find("SEManager5").GetComponent<AudioSource>().enabled = false;
            cowLFCol.enabled = false;
            One = false;
            Debug.Log("1");
        }

        if (totalAttackTime <= 0)
        {
            Start();
        }
    }
    




    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            cowBoy.enabled = true;
            agent.enabled = true;
            this.enabled = false;
        }
    }

}