using UnityEngine;
using UnityEngine.UI;

public class DeckControll : MonoBehaviour
{
    public cardSO card;
    void Start()
    {
        GetComponent<Image>().sprite = card.icon;
    }
    public void Pickup()
    {
        //Invenbtryの追加（アイテムの取得）
       // Hand.Instance.Add(card);
        //アイテムを消したいとき。
        //Destroy(gameObject);
    }
}
