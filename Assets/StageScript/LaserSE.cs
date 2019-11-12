using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSE : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("laserBit").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            audioSource.enabled = true;
        }

    }

   
    }
