using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CanvasActive : MonoBehaviour
{
    [SerializeField] GameObject OnCanvas;               //表示させるキャンバス
    [SerializeField] GameObject OffCanvas;              //非表示にするキャンバス
    [SerializeField] GameObject trasitionPrefab;        //間に表示するキャンバス
    private float waitTime = 1.0f;                      //キャンバスが遷移するまでの時間

    public void ActiveCanvas()
    {
        StartCoroutine("LoadCanvas");
    }

    IEnumerator LoadCanvas()
    {
        Instantiate(trasitionPrefab);
        yield return new WaitForSeconds(waitTime);
        OnCanvas.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        OffCanvas.SetActive(false);
    }
}
