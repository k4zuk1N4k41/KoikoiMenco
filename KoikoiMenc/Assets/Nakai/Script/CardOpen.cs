using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardOpen : MonoBehaviour
{
    [SerializeField] CardInstanceInfo GameInfo;
    [SerializeField] GameObject OnCanvas;               //表示させるキャンバス
    [SerializeField] GameObject OffCanvas;              //非表示にするキャンバス
    [SerializeField] GameObject trasitionPrefab;        //間に表示するキャンバス
    [SerializeField] GameObject[] CardUra;
    [SerializeField] Cardmean[] CardObject;
    [SerializeField] GameObject[] ResultObjects;
    float waitTime = 0.1f;
    int[] PlayerOrder;

    public void CardOpenHit()
    {
        PlayerOrder = new int[2];
        StartCoroutine("StartCardImage");
    }

    IEnumerator StartCardImage()
    {
        int i;

        for (i = 0; i < CardObject.Length; i++)
        {
            yield return new WaitForSeconds(waitTime);
            CardObject[i].GetCardStatusInfo();
        }
        yield return new WaitForSeconds(1);
        for (i = 0; i < CardUra.Length; i++)
        {
            CardUra[i].gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(1);
        for(i = 0;i < 2; i++)
        {
            PlayerOrder[i] = CardObject[i].CardData.Month;
        }
        yield return new WaitForSeconds(0.5f);
        if (PlayerOrder[0] < PlayerOrder[1])
        {
            ResultObjects[0].SetActive(true);
            ResultObjects[3].SetActive(true);
            GameInfo.Player1Flag = 1;
            yield return new WaitForSeconds(3);
            Instantiate(trasitionPrefab);
            yield return new WaitForSeconds(1);
            OnCanvas.SetActive(true);
            yield return new WaitForSeconds(1);
            OffCanvas.SetActive(false);
        }
        else if (PlayerOrder[0] > PlayerOrder[1])
        {
            ResultObjects[1].SetActive(true);
            ResultObjects[2].SetActive(true);
            GameInfo.Player2Flag = 1;
            yield return new WaitForSeconds(3);
            Instantiate(trasitionPrefab);
            yield return new WaitForSeconds(1);
            OnCanvas.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            OffCanvas.SetActive(false);
        }
        else
        {

            for (i = 0; i < CardUra.Length; i++)
            {
                CardUra[i].gameObject.SetActive(true);
            }
        }
    }
}
