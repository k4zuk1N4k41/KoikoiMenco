using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    [SerializeField] GameObject targetPoint;      //ロックオンカーソル

    [SerializeField] float xSpeed;      //横方向の移動速度
    [SerializeField] float ySpeed;      //縦方向の移動速度

    public bool isLocked;
    public bool GetResult = false;

    [SerializeField] CardInstanceInfo info;
    public GameObject cardObj;

    [SerializeField] Cardmean cardMean;
    [SerializeField] PowerGage gage;
    [SerializeField] LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
        //ロックオン状態じゃないときに動かせるようにする
        if (!isLocked)
        {
            TargetMove();
        }

        //スペースキーを押したときにカーソルの場所を確定する
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isLocked = true;
            

            // タップした場所からRayを作成
            Ray ray = Camera.main.ScreenPointToRay(this.gameObject.transform.position);
            Vector2 vector2 = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            // Raycastを作成
            RaycastHit2D hit2d = Physics2D.Raycast(vector2, (Vector2)ray.direction, Mathf.Infinity);

            //Rayが何かに衝突したことを検知 & 衝突した対象が自分自身かを判別
            if (hit2d && hit2d.transform.gameObject.CompareTag("Ura"))
            {
                gage.isGageStart = true;
                cardObj = hit2d.transform.gameObject;
                hit2d = Physics2D.Raycast(vector2, (Vector2)ray.direction, Mathf.Infinity, layerMask);
                Debug.Log(hit2d);

                if (hit2d)
                {
                    cardObj = hit2d.transform.gameObject;
                    cardMean = cardObj.GetComponent<Cardmean>();
                    info.CardAfter = cardMean;
                    GetResult = true;
                }

            }
        }
    }
    /// <summary>
    /// ロックオンカーソルを動かす関数
    /// </summary>
    public void TargetMove()
    {
        //Wキーを押している間の処理
        if (Input.GetKey(KeyCode.W))
        {
            targetPoint.transform.position += new Vector3(0, ySpeed, 0);
        }
        //Sキーを押している間の処理
        else if (Input.GetKey(KeyCode.S))
        {
            targetPoint.transform.position += new Vector3(0, ySpeed * -1, 0);
        }
        //Aキーを押している間の処理
        else if (Input.GetKey(KeyCode.A))
        {
            targetPoint.transform.position += new Vector3(xSpeed * -1, 0, 0);
        }
        //Dキーを押している間の処理
        else if (Input.GetKey(KeyCode.D))
        {
            targetPoint.transform.position += new Vector3(xSpeed, 0, 0);
        }
    }
}
