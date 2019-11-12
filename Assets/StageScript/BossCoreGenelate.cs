using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCoreGenelate : MonoBehaviour
{
    public GameObject core;

    public AudioClip CannonSE;

    private Animator animator;
    private AudioSource audioSource;
    private Rigidbody bulletrgbody;
    private int bulletwaitTime = 4;

    public int coreCount = 1;

    public float PosX;
    public float PosY;
    public float PosZ;

    public float firewaitTime;
    public float firewaitCount;
    public float Firetime;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
     
    }

    // Update is called once per frame
    void Update()
    {
        coreCount = 1;

        if (coreCount % 100 == 0)
        {
            var canonBoll = Instantiate(core, transform.position = new Vector3(PosX, PosY, PosZ), Quaternion.identity);
                audioSource.PlayOneShot(CannonSE);
                Debug.Log(bulletwaitTime);
            }
        
        }
    }

