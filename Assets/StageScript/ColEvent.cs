using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColEvent : MonoBehaviour
{
    public Image image;
    public Text Say;
    public Text Say2;
    public Canvas PlayerCan;
    public ColEvent2 event2;

    public GameObject Woman;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            image.gameObject.SetActive(true);
            PlayerCan.gameObject.SetActive(false);
           
            GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;

            Invoke("RetunePlay", 5f);
        }
    }

    void RetunePlay()
    {
        Woman.SetActive(false);
        image.gameObject.SetActive(false);
        Say2.gameObject.SetActive(true);
        Say.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);
    

        GameObject.Find("ma").GetComponent<PlayerHP>().enabled = true;

        
    }

}
