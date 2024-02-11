using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSelect : MonoBehaviour
{
    [SerializeField] CardInstanceInfo Info;
    [SerializeField] Cardmean cardmean;
    [SerializeField] GameObject TargetCarsor;
    public void OnPlayer1PointerEnter()
    {
        if (Info.Player1Flag == 1)
        {
            transform.position += Vector3.up * 0.3f;
            transform.localScale = Vector3.one * 1.3f;
        }
        return;
    }
    // Start is called before the first frame update
    public void OnPlayer1PointerExit()
    {
        if (Info.Player1Flag == 1)
        {
            transform.localScale = Vector3.one;
            transform.position += Vector3.down * 0.3f;
        }
        return;
    }
    public void OnPlayer2PointerEnter() 
    {
        if (Info.Player2Flag == 1)
        {
            transform.position += Vector3.up * 0.3f;
            transform.localScale = Vector3.one * 1.3f;
        }
        return;
    }

    public void OnPlayer2PointerExit()
    {
        if (Info.Player2Flag == 1)
        {
            transform.localScale = Vector3.one;
            transform.position += Vector3.down * 0.3f;
        }
        return;
    }

    public void PointaInstance()
    {
        Info.CardBefore = cardmean;
        Cursor.visible = false;
        TargetCarsor.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
