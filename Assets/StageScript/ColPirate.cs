﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColPirate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject.Find("GameDirector").GetComponent<St4ColEvent>().enabled = true;
        }
    }
}
