using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintText : MonoBehaviour
{
    public string jaText;
    public string enText;
    public string chText;
    public Text text;

    private void Update()
    {
        switch (LocalDirector.language)
        {
            case Language.Japanese:
                text.text = jaText;
                break;
            case Language.English:
                text.text = enText;
                break;
            case Language.Chinese:
                text.text = chText;
                break;
        }
    }
}
