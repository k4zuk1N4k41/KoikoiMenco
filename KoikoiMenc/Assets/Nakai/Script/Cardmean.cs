using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Cardmean : MonoBehaviour
{
    public CardInstanceInfo CardInstanceInfos;
    public CardDatabase CardDatabase;
    public Image GetCardImage;         //カードの画像
    public Text GetPointImage;         //カードの点数を表示
    public Text GetMonthText;          //カードの月を表示
    public CardData CardData;                 //スクリプタブルオブジェクトを格納する
    private int cardID;                //引くカードの番号を格納する
    
    public void GetCardStatusInfo()
    {
        var tmpCardId = Random.Range(1, CardInstanceInfos.Cards.Count);
        cardID = CardInstanceInfos.Cards[tmpCardId];
        CardInstanceInfos.Cards.RemoveAt(tmpCardId);
        CardData = CardDatabase.cardDatas.FirstOrDefault(card => card.Id == cardID);        //当てはまるIDのデータを取得する。
        GetCardImage.sprite = CardData.CardImage;                                           //カードの画像を表示 
        GetPointImage.text = CardData.point.ToString();                                     //カードのポイントを表示
        GetMonthText.text = string.Format("{0}月", CardData.Month);                         //カードの月を表示
    }
}
