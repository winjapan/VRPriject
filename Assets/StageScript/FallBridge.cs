using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBridge : MonoBehaviour
{
    AudioSource audioSource;
    public float fallSpeed;
    public float fallwaiteTime;
    public AudioClip BridgeBreak;

    bool isKinematic = true;

     void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            this.gameObject.layer = LayerMask.NameToLayer("FallDown");
            Invoke("Fall", 0.2f);
            isKinematic = false;
            audioSource.PlayOneShot(BridgeBreak);
        }


    }

    void Fall()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        fallSpeed = 1000;

        if (transform.position.y < -1f)
        {
            Destroy(gameObject);
        }
    }

}
