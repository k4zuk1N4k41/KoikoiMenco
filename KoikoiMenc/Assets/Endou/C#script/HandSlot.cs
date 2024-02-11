using UnityEngine;
using UnityEngine.UI;

public class HandSlot : MonoBehaviour
{
    public Image icon;

    cardSO card;

    public void AddCard(cardSO newcard)
    {
        card = newcard;
        icon.sprite = newcard.icon;
        Debug.Log("AddCard");
    }
}

//    public void EquipmentWeapon()
//    {
//        if (weapon == null)
//        {
//            return;
//        }
//        weapon.Equipment();
//    }
//}
