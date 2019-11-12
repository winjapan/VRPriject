using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicGanelate : MonoBehaviour
{
    public GameObject MgEffect;

    public float PosX;
    public float PosY;
    public float PosZ;

    public int mgCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mgCount += 1;

        if (mgCount % 100 == 0)
        {
            var bulletF = Instantiate(MgEffect, transform.position = new Vector3(PosX, PosY, PosZ), Quaternion.identity);


        }
    }
}