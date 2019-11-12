using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController2 : MonoBehaviour
{
    public Text StoryTitle;
    public Text EndText;

    public AudioClip EndSound;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        {

           

            StartCoroutine(ClearTelop());
        }
    }

      IEnumerator ClearTelop()
      {
       StoryTitle.gameObject.SetActive(true);

       EndText.gameObject.SetActive(true);

       audioSource.PlayOneShot(EndSound);


        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("Stage2Scene");
     }
}
