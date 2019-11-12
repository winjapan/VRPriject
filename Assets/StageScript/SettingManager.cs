using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public Button SettingButton;
    public Button ReturnButton;
    public Image SettingImage;
    public Canvas StartC;
    public Canvas Title;
    public Canvas Set;

    Button button;
    [Multiline]
    [SerializeField]
    public static bool ChangeLanguageEn;
    public static bool ChangeLanguageCh;

    public Button English;
    public Button Chinese;
    public Button Japanese;

    AudioSource audioSource;

   // public GameObject 
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
        //設定バトンが押されたら、設定イメージを開く
        SettingImage.gameObject.SetActive(true);
        GameObject.Find("TitleBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("SettingBGM").GetComponent<AudioSource>().enabled = true;

        StartC.gameObject.SetActive(false);
        Title.gameObject.SetActive(false);
        Set.gameObject.SetActive(true);

    }

}
