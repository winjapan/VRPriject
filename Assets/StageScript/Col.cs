using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col : MonoBehaviour
{
    public St4ColEvent St4Col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            St4Col.enabled = true;
        }
    }
}
