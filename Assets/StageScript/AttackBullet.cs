using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBullet : MonoBehaviour
{
    public int bulletSpeed = 1;
    Rigidbody rgbody;
    Vector3 Posx;
    Vector3 PosY;
    // Start is called before the first frame update
    void Start()
    {
        bulletSpeed = 10;
        rgbody = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
        rgbody.AddForce(transform.position.x - bulletSpeed,transform.position.y,0);
        // Debug.Log(transform.position.x);
        Destroy(gameObject,1f);

    }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
           Destroy(gameObject);
//           Debug.Log("Player");
        }
    }
}

