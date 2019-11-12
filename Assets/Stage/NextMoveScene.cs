using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextMoveScene : MonoBehaviour
{
    public Text Story2;
 

    public AudioClip Win;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Next());
        }
    }

    IEnumerator Next()
    {
        Story2.gameObject.SetActive(true);
        audioSource.PlayOneShot(Win);

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("Stage3Scene");
    }
}
