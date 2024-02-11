using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CanvasActive : MonoBehaviour
{
    [SerializeField] GameObject OnCanvas;               //�\��������L�����o�X
    [SerializeField] GameObject OffCanvas;              //��\���ɂ���L�����o�X
    [SerializeField] GameObject trasitionPrefab;        //�Ԃɕ\������L�����o�X
    private float waitTime = 1.0f;                      //�L�����o�X���J�ڂ���܂ł̎���

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
