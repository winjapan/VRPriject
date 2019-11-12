using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearController : MonoBehaviour
{
    public bool isTrriger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTrriger = true;
            GameObject.Find("GameDirector").GetComponent<FinalClearEvent>().enabled = true;
        }
    }


}
