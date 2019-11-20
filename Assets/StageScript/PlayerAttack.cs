using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject PunchEffect;
    public GameObject KickerEffect;

    private float effectPunchSpeed = 2.0f;
    private float effectPunchHeight = 6000f;
    private float effectPunchWidth = 55f;
    private float effectKickSpeed = 2.0f;
    private float effectKickHeight = 500f;
    private float effectKickWidth = 1f;

    public AudioClip Attack1;
    public AudioClip Attack2;
    public AudioClip Lefthook;
    public AudioClip Damage;

    private Collider upperRCol;
    private Collider upperLCol;
    private Collider lowerRLegCol;

    private Animator animator;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(Attack());
        upperRCol = GameObject.Find("upperLeg.R").GetComponent<SphereCollider>();
        upperLCol = GameObject.Find("upperLeg.L").GetComponent<SphereCollider>();
        lowerRLegCol = GameObject.Find("lowerLeg.R").GetComponent<SphereCollider>();
    }

    IEnumerator Attack()
    {
        if (GvrControllerInput.AppButtonDown && !animator.GetCurrentAnimatorStateInfo(0).IsName("GvrControllerInput.Accel") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack")
        && !animator.IsInTransition(0))
        {
            StartCoroutine(RPunch());
            Debug.Log(" 右");
            var Righteffect = Instantiate(PunchEffect, transform.position + Vector3.up * effectPunchSpeed * effectPunchWidth * effectPunchHeight, Quaternion.FromToRotation(Vector3.forward, transform.forward));
        }


        yield return new WaitForSeconds(0.5f);
        if (GvrControllerInput.AppButtonUp && !animator.GetCurrentAnimatorStateInfo(0).IsName("GvrControllerInput.Accel") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack2") && !animator.IsInTransition(0))
        {
            StartCoroutine(LPunch());
            var Lefteffect = Instantiate(PunchEffect, transform.position + Vector3.up * 0f * effectPunchSpeed * effectPunchWidth * effectPunchHeight, Quaternion.FromToRotation(Vector3.forward, transform.forward));
        }

        yield return new WaitForSeconds(0.5f);

        if (GvrControllerInput.TouchDown && !animator.GetCurrentAnimatorStateInfo(0).IsName("GvrControllerInput.Accel") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack3") && !animator.IsInTransition(0))
        {
            StartCoroutine(KickAttack());
            var kickEffect = Instantiate(KickerEffect, transform.position + Vector3.up / 150 * effectKickSpeed * effectKickWidth * effectKickHeight, Quaternion.FromToRotation(Vector3.up, transform.up)) as GameObject;
        }
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator RPunch()
    {
        this.gameObject.layer = LayerMask.NameToLayer("RightPunch");

        upperRCol.enabled = true;
        animator.SetBool("Attack", true);
        audioSource.PlayOneShot(Attack1);

        yield return new WaitForSeconds(1f);

        this.gameObject.layer = LayerMask.NameToLayer("Player");
        animator.SetBool("Attack", false);
        upperRCol.enabled = false;

    }

    IEnumerator LPunch()
    {
        this.gameObject.layer = LayerMask.NameToLayer("LeftPunch");

        upperLCol.enabled = true;
        animator.SetBool("Attack2", true);
        audioSource.PlayOneShot(Lefthook);


        yield return new WaitForSeconds(1f);

        //終わったら、レイヤーをプレイヤーに戻し、アニメーターはアイドルに、当たり判定のコライダーはオフにする。
        this.gameObject.layer = LayerMask.NameToLayer("Player");
        animator.SetBool("Attack2", false);
        upperLCol.enabled = false;

    }

    IEnumerator KickAttack()
    {
        this.gameObject.layer = LayerMask.NameToLayer("Kick");

        animator.SetBool("Attack3", true);
        audioSource.PlayOneShot(Attack2);
        lowerRLegCol.enabled = true;


        yield return new WaitForSeconds(1f);


        this.gameObject.layer = LayerMask.NameToLayer("Player");
        lowerRLegCol.enabled = false;

    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (GvrControllerInput.AppButtonDown && !animator.GetCurrentAnimatorStateInfo(0).IsName("GvrControllerInput.Accel") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack")
    //     && !animator.IsInTransition(0))
    //    {
    //        StartCoroutine(RPunch());
    //        Debug.Log(" 右");
    //        var Righteffect = Instantiate(PunchEffect, transform.position + Vector3.up * effectPunchSpeed * effectPunchWidth * effectPunchHeight, Quaternion.FromToRotation(Vector3.forward, transform.forward));
    //    }

    //    if (GvrControllerInput.AppButtonUp && !animator.GetCurrentAnimatorStateInfo(0).IsName("GvrControllerInput.Accel") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack2") && !animator.IsInTransition(0))
    //    {
    //        StartCoroutine(LPunch());
    //        var Lefteffect = Instantiate(PunchEffect, transform.position + Vector3.up * 0f * effectPunchSpeed * effectPunchWidth * effectPunchHeight, Quaternion.FromToRotation(Vector3.forward, transform.forward));
    //    }



    //    if (GvrControllerInput.TouchDown && !animator.GetCurrentAnimatorStateInfo(0).IsName("GvrControllerInput.Accel") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack3") && !animator.IsInTransition(0))
    //    {
    //        StartCoroutine(KickAttack());
    //        var kickEffect = Instantiate(KickerEffect, transform.position + Vector3.up / 150 * effectKickSpeed * effectKickWidth * effectKickHeight, Quaternion.FromToRotation(Vector3.up, transform.up)) as GameObject;
    //    }

    //}
}
