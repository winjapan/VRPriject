using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpoldeGenelator : MonoBehaviour
{
    public GameObject ExEffect;

    public float PosX;
    public float PosY;
    public float PosZ;

    public int exCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        exCount += 1;

        if (exCount % 100 == 0)
        {
            var bulletF = Instantiate(ExEffect, transform.position = new Vector3(PosX,PosY,PosZ), Quaternion.identity);


        }
    }
}