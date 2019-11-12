using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public AudioClip Title;
    public AudioClip Setting;

    public bool setSound;


    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //タイトル画面での切り替えについて
        //タイトルの押したバトンが設定だったら？
        //一時的に音楽をsettingに変える
        if (gameObject.tag == "SettingButton")
        { 

        }
    }

        public void OnButtonClicked()
    {

    }
}
