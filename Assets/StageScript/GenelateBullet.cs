using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenelateBullet : MonoBehaviour
{
    int bulletCount = 1;
    public int bulletSpeed = 10000;

    public GameObject target;
    public GameObject Bullet;

    public AudioClip BulletSE;

    private Animator animator;
    private AudioSource audioSource;
    private Rigidbody bulletrgbody;
    private int bulletwaitTime = 4;

    public float Posx;
    public float Posy;
    public float Posz;

    private float RotateZ = 5f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        bulletCount += 1;
       
            if (bulletCount % 100 == 0)
            {
                var bullet = Instantiate(Bullet, transform.position = new Vector3(Posx,Posy,Posz), transform.rotation = new Quaternion(0, 0, RotateZ, 5.5f));
                audioSource.PlayOneShot(BulletSE);
                Debug.Log(bulletwaitTime);
            }

        
       // if (bulletwaitTime < 0)
       // {

        //    return;
       // }
       }
    }
   

