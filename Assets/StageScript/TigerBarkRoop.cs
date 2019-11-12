using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerBarkRoop : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    public AudioClip tiger;

    public float barkTime = 10; 
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        barkTime = 10;

    }

    // Update is called once per frame
    void Update()
    {
        barkTime -= Time.deltaTime;

        if (barkTime <5)
        {
            animator.SetBool("sound",true);
            GameObject.Find("TigerSound").GetComponent<AudioSource>().enabled = true;
            GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = true;
        }

        if (barkTime < 4)
        {
            animator.SetBool("sound", false);
            GameObject.Find("TigerSound").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = false;
        }

        if (barkTime <0)
        {
            Start();
        }
    }
}
