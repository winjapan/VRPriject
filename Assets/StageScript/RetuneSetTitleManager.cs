using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetuneSetTitleManager : MonoBehaviour
{

    public Button ReturnButton;
   

    public Canvas StartC;
    public Canvas Title;
    public Canvas Set;
    Button button;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClicked()
    {
        //戻るバトンがおされたら、タイトルに戻る
        Set.gameObject.SetActive(false);
        GameObject.Find("TitleBGM").GetComponent<AudioSource>().enabled = true;
        GameObject.Find("SettingBGM").GetComponent<AudioSource>().enabled = false;

       
        Title.gameObject.SetActive(true);
        StartC.gameObject.SetActive(true);
    }
}


