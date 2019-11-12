using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCode : MonoBehaviour
{
    [SerializeField, Space(5)]

    int count = 6;
    [SerializeField, Multiline(5)]
    string message1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
