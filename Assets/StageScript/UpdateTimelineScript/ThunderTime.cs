using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderTime : MonoBehaviour
{
    public Light light;

    public float thunderTime = 10;

    // Start is called before the first frame update
    void Start()
    {
        thunderTime = 10;

        light = GameObject.Find("Thunder Light").GetComponent<Light>();
       
    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        thunderTime -= Time.deltaTime;

        if (thunderTime < 8)
        {
            light.enabled = true;
           // Debug.Log(thunderTime);
        }

        if (thunderTime < 7.5)
        {
            light.enabled = false;
        }

        if (thunderTime < 5)
        {
            light.enabled = true;
           // Debug.Log(thunderTime);
        }

        if (thunderTime < 4.5)
        {
            light.enabled = false;
        }

        if (thunderTime < 4)
        {
            light.enabled = true;
            //Debug.Log(thunderTime);
        }

        if (thunderTime < 3.7)
        {
            light.enabled = false;
        }


        if (thunderTime < 3)
        {
            light.enabled = true;
           // Debug.Log(thunderTime);
        }

        if (thunderTime < 2)
        {
            light.enabled = false;
        }


      

        if (thunderTime < 1.5)
        {
            light.enabled = true;
            //Debug.Log(thunderTime);
        }

        if (thunderTime < 0.5)
        {
            light.enabled = false;
        }

        if (thunderTime <0)
        {
            Start();
        }
    }
}
