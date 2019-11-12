using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTime : MonoBehaviour
{
    public GameObject Effect;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObj", 2f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void DestroyObj()
    {
        Destroy(Effect);
    }
}
