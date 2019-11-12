using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScene_Manager : MonoBehaviour {

    public string[] AnimationNames;
    public int CurrentIndex;

	public void NextAnimation()
    {
        if (CurrentIndex >= AnimationNames.Length)
            CurrentIndex = 0;
        GetComponent<Animation>().Play(AnimationNames[CurrentIndex]);
        CurrentIndex++;
    }

    public void OpenWeb(string web)
    {
        Application.OpenURL(web);
    }
}
