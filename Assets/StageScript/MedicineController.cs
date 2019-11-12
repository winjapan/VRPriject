using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ちから丹（青）、謎の丹藥（赤）、回復丹（緑）をスクリプトで消す
public class MedicineController : MonoBehaviour
{
    public GameObject PowerMedicine;
    public GameObject InvincibleMedicine;
    public GameObject RepairMedicine;

    public AudioClip ItemGet;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   void OnTriggerEnter(Collider other)
    {
        //ちから丹、謎の丹薬、回復丹に当たったキャラクターがプレイヤーだったら？
        //３つの丹薬を消す（Destroy）
        //当たったと同時に、効果発動（プレイヤースクリプトで操作）
        //ちから丹と謎の丹薬については、コルーチンを使って通常→効果→通常に戻るようにする
        //追加！
        //効果音を鳴らしてみよう！
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(ItemGet, transform.position);
            Destroy(gameObject);

        }

    }
}
