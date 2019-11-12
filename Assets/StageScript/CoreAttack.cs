using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreAttack : MonoBehaviour
{
    public GameObject core;
    public GameObject exeffect;
    private Rigidbody rgbody;

    private int coreSpeed = 1;
   // private int coreHeight;

    // Start is called before the first frame update
    void Start()
    {
        coreSpeed = 1;
        rgbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rgbody.AddForce(0,transform.position.y, transform.position.z - coreSpeed);
        // Physics.gravity = new Vector3(0,-30,0);
       
    }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Bridge")
        {
            var canonExplode = Instantiate(exeffect, transform.position, Quaternion.identity);
            Destroy(core,0.5f);


        }

        if (hit.gameObject.tag == "Player")
        {
            var canonExplode = Instantiate(exeffect, transform.position, Quaternion.identity);
            Destroy(core, 0.5f);
        }

        if(hit.gameObject.tag == "Staircase")
        {
            var canonExplode = Instantiate(exeffect, transform.position, Quaternion.identity);
            Destroy(core, 0.5f);
        }
    }
}
