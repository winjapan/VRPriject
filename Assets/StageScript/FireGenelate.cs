using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGenelate : MonoBehaviour
{
    public GameObject BulletMagic;

    public float PosX;
    public float PosY;
    public float PosZ;

    public int FireCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FireCount += 1;

        if (FireCount % 100 == 0)
        {
            var bulletF = Instantiate(BulletMagic, transform.position,Quaternion.identity);

           
        }
    }
}
