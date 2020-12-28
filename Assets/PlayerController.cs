using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10;

    private void FixedUpdate()
    {
       // Rigidbodyを取得
       Rigidbody rigidbody = GetComponent<Rigidbody>();

       // 方向キーの入力
       float x = Input.GetAxis("Horizontal"); // 横軸
       float z = Input.GetAxis("Vertical");   // 縦軸

       // ベクトルに変換
       Vector3 vec = new Vector3(x, 0, z);

       vec = vec * speed;

       // 力を加える
       rigidbody.AddForce(vec);
    }

}
