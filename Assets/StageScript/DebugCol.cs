﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            Debug.Log("aaa");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aaa");
    }
}
