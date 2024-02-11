using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Cardmean : MonoBehaviour
{
    public CardInstanceInfo CardInstanceInfos;
    public CardDatabase CardDatabase;
    public Image GetCardImage;         //�J�[�h�̉摜
    public Text GetPointImage;         //�J�[�h�̓_����\��
    public Text GetMonthText;          //�J�[�h�̌���\��
    public CardData CardData;                 //�X�N���v�^�u���I�u�W�F�N�g���i�[����
    private int cardID;                //�����J�[�h�̔ԍ����i�[����
    
    public void GetCardStatusInfo()
    {
        var tmpCardId = Random.Range(1, CardInstanceInfos.Cards.Count);
        cardID = CardInstanceInfos.Cards[tmpCardId];
        CardInstanceInfos.Cards.RemoveAt(tmpCardId);
        CardData = CardDatabase.cardDatas.FirstOrDefault(card => card.Id == cardID);        //���Ă͂܂�ID�̃f�[�^���擾����B
        GetCardImage.sprite = CardData.CardImage;                                           //�J�[�h�̉摜��\�� 
        GetPointImage.text = CardData.point.ToString();                                     //�J�[�h�̃|�C���g��\��
        GetMonthText.text = string.Format("{0}��", CardData.Month);                         //�J�[�h�̌���\��
    }
}
