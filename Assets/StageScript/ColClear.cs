﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColClear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject.Find("GameDirector").GetComponent<FinalClearEvent>().enabled = true;
        }
    }
}
