using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalStageMoveScene : MonoBehaviour
{
    public Text Clear1;
    public Text Clear2;

    private AudioSource audioSource;
    public AudioClip Bell; 

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
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(NextFinal());
        }
    }

    IEnumerator NextFinal()
    {
        Clear1.gameObject.SetActive(true);
        Clear2.gameObject.SetActive(true);
        audioSource.PlayOneShot(Bell);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("FinalStageScene");
    }
}
