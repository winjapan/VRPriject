using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGenelate : MonoBehaviour
{
    public GameObject LaserEffect;

    public float PosX;
    public float PosY;
    public float PosZ;

    public int laserCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        laserCount += 1;

        if (laserCount % 100 == 0)
        {
            var bulletF = Instantiate(LaserEffect, transform.position = new Vector3(PosX, PosY, PosZ), Quaternion.identity);


        }
    }
}
