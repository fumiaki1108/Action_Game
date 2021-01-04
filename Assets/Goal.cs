using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // ゴールに表示するテキスト
    public GameObject goalText;

    // トリガーに接触した瞬間に呼ばれる処理
    void OnTriggerEnter(Collider collider)
    {
        // 接触したのはがプレイヤーか？
        if (collider.gameObject.CompareTag("Player"))
        {
            // ゴールを表示
            goalText.SetActive(true);
        }
    }

}