using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryUnityChan : MonoBehaviour
{
    public float angryTime;
    private Collider agCol;
    public AudioSource playerAudio;
    bool isSound;
    // Start is called before the first frame update
    void Start()
    {
        angryTime = 2;
       
    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        angryTime -= Time.deltaTime;

        if (angryTime < 2)
        {
            playerAudio.enabled = true;
            isSound = true;
        }

        if (angryTime < 1)
        {
            playerAudio.enabled = false;
            isSound = false;
        }

        if (angryTime <0)
        {
            Start();
        }
    }
}
