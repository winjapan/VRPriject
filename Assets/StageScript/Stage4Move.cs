using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage4Move : MonoBehaviour
{
    public Text Story3;
    public Text Story33;

    public AudioClip win;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Next4());
        }
    }

    IEnumerator Next4()
    {
        Story3.gameObject.SetActive(true);

        Story33.gameObject.SetActive(true);

        audioSource.PlayOneShot(win);

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Stage4Scene");
    }
}
