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
        //Invenbtry�̒ǉ��i�A�C�e���̎擾�j
       // Hand.Instance.Add(card);
        //�A�C�e�������������Ƃ��B
        //Destroy(gameObject);
    }
}
