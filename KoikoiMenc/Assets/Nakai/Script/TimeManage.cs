using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManage : MonoBehaviour
{
    [SerializeField] CardInstanceInfo GameInfo;
    [SerializeField] Cardmean[] CardImages;
    [SerializeField] GameObject[] Player1CardUra;
    [SerializeField] GameObject[] Player2CardUra;
    [SerializeField] GameObject[] FieldCardUra;
    [SerializeField] GameObject Player1Turn;
    [SerializeField] GameObject Player2Turn;
    [SerializeField] Button[] Player1Cards;
    [SerializeField] Button[] Player2Cards;
    [SerializeField] Animation Card_01;     //��ɏオ��
    [SerializeField] Animation Card_02;     //���ɉ�����
    [SerializeField] bool isSelect = false;

    float waitTime = 0.1f;

    private void OnEnable()
    {
        StartCard();
    }

    IEnumerator StartCardImage()
    {
        for (int i = 0; i < CardImages.Length; i++)
        {
            yield return new WaitForSeconds(waitTime);
            CardImages[i].GetCardStatusInfo();
        }
        yield return null;
        for (int i = 0;i < Player1CardUra.Length; i++) 
        {
            Player1CardUra[i].SetActive(false);
            Player2CardUra[i].SetActive(false);
        }
    }

    public void StartCard()
    {
        GameInfo.Cards.Clear();
        for (int i = 1; i <= 48; i++)
        {
            GameInfo.Cards.Add(i);
        }
        
        StartCoroutine("StartCardImage");

        //Player1�̃^�[���̂Ƃ�
        if (GameInfo.Player1Flag == 1) 
        { 
            Player1Turn.SetActive(true);
            Player2Turn.SetActive(false);
            for (int i = 0; i < Player1Cards.Length; i++)
            {
                Player2Cards[i].interactable = false;
            }
        }
        //Player2�̃^�[���̂Ƃ�
        else if (GameInfo.Player2Flag == 1)
        {
            Player1Turn.SetActive(false);
            Player2Turn.SetActive(true);
            for (int i = 0; i < Player1Cards.Length; i++)
            {
                Player1Cards[i].interactable = false;
            }
        }
    }
}
