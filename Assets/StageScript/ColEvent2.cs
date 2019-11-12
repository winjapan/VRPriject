using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 
ColEvent2 : MonoBehaviour
{
    public Image image;
    public Image playerImage;
    public Canvas PlayerCan;

    public GameObject LadyFighter;

    public float eventTime;
    // Start is called before the first frame update
    void Start()
    {
        eventTime = 12;
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;

            Debug.Log("export/" + procount);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {

            StartCoroutine(NextEvent());
        }
    }

  IEnumerator NextEvent()
    {
            image.gameObject.SetActive(true);
            PlayerCan.gameObject.SetActive(false);
         
            GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;

        yield return new WaitForSeconds(5f);
            image.gameObject.SetActive(false);
            playerImage.gameObject.SetActive(true);

        yield return new WaitForSeconds(5f);
            LadyFighter.SetActive(false);
            playerImage.gameObject.SetActive(false);
            PlayerCan.gameObject.SetActive(true);
          
            GameObject.Find("ma").GetComponent<PlayerHP>().enabled = true;


    }

}
