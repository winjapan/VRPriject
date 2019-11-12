using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bom : MonoBehaviour
{
    public GameObject BomExploxion;

    private Rigidbody rgbody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Explode()
    {
        GameObject exeffect = Instantiate(BomExploxion, transform.position, Quaternion.identity);
        Destroy(exeffect, 2.5f);
        //GetComponent<MeshRenderer>().enabled = false;
        StartCoroutine(CleateExplode(Vector3.right));
        StartCoroutine(CleateExplode(Vector3.left));

        Destroy(this.gameObject, 1f);
    }

    IEnumerator CleateExplode(Vector3 direction)
    {
        for (int i = 0; i < 2; i++)
        {
            RaycastHit hit;
            Physics.Raycast(transform.position + new Vector3(1, 0, 0), direction, out hit, i);

            if (!hit.collider)
            {
                GameObject exeffect = Instantiate(BomExploxion, transform.position + (i * direction), BomExploxion.transform.rotation);

                Destroy(exeffect, 2.5f);
            }
            else
            {
                break;
            }

            yield return new WaitForSeconds(0.005f);
        }
    }


    private void OnTriggerEnter(Collider hit)
    {


        if (hit.gameObject.tag == "Plane")
        {

            Invoke("Explode", 0.5f);

        }

    }
} 