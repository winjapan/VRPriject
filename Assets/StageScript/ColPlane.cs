using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColPlane : MonoBehaviour
{
    public GameObject Plane000;
    public GameObject ShockWave;

    public AudioClip Rock;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "mace")
        {

            audioSource.PlayOneShot(Rock);
            var shock = Instantiate(ShockWave, transform.position + Vector3.forward, Quaternion.FromToRotation(Vector3.forward, transform.forward));
            
        }
    }
}
