using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakMast : MonoBehaviour
{
    public AudioClip des;

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
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "RPunch")
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(des, transform.position);
        }
    }
}
