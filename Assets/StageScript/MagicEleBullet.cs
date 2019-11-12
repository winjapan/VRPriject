using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicEleBullet : MonoBehaviour
{
    public GameObject MagigEleEffect;
    private Rigidbody rgbody;

    private int mgSpeed = 10;
    // private int coreHeight;

    // Start is called before the first frame update
    void Start()
    {
        mgSpeed = 1;
        rgbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rgbody.AddForce(transform.position.x - mgSpeed, transform.position.y, 0);
        // Physics.gravity = new Vector3(0,-30,0);

    }
}
