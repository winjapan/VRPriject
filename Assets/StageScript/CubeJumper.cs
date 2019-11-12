using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeJumper : MonoBehaviour
{
    public Vector3 force;
    public float timer = 0;
    Rigidbody rb;
    int jumpCount = 2;
    List<float> accYList = new List<float>();


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
//        Debug.LogFormat("<color=yellow>accYQueue.Count {0}</color>", accYQueue.Count);
        var conAccY = GvrControllerInput.Accel;
        Debug.Log(conAccY);
        //accYList.Add(conAccY);

        if (accYList.Count > 120)
        {
            accYList.RemoveAt(0);

        }
       //Debug.LogFormat("<color=red>average {0}</color>", accYList[0]);
    }

    float Average(List<float> list)
    {
        float sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        return sum / list.Count;
    }

    void Jump()
    {
        rb.AddForce(force);
        jumpCount++;
    }
}
