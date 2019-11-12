using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Language {
    Japanese,
    English,
    Chinese
  }

public class LocalDirector : MonoBehaviour
{
    public static Language language = Language.Japanese;

    public void JapaneseClicked() 
    {
        language = Language.Japanese;
    }

    public void EnglishClicked()
    {
        language = Language.English;
    }


    public void ChineseClicked()
    {
        language = Language.Chinese;
    }

}
