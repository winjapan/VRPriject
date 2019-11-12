using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBosController : MonoBehaviour
{
    public GameObject LastBoss;
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
            LastBoss.SetActive(true);
           
          
            GameObject.Find("GameDirector").GetComponent<FinalBossEvent>().enabled = true;
            GameObject.Find("LastBGM").GetComponent<AudioSource>().enabled = false;
            Invoke("Next" ,0.3f);
        }
    }

    void Next()
    {
        Destroy(this.gameObject);
    }
}
