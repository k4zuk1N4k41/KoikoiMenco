using System.Collections;
using System.Collections.Generic;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    [SerializeField] private CardInstanceInfo cardinfo;
    [SerializeField] private Image player1Hp;
    [SerializeField] private Image player2Hp;
    [SerializeField] private ChangeScene changeScene;
    [SerializeField] private TimeManage timeManager;
    [SerializeField] private GameObject handCard1;
    [SerializeField] private GameObject handCard2;
    
    // Start is called before the first frame update
    void Start()
    {
        InitHP();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Damege();
        }
    }

    public void Damege()
    {
        int value;
        
        value = cardinfo.CardBefore.CardData.point + cardinfo.CardAfter.CardData.point;
        //value = 10;
        if (cardinfo.Player1Flag == 1)
        {
            Player2Damage(value);
        }
        else if (cardinfo.Player2Flag == 1)
        {
            Player1Damage(value);
        }
    }

    private void Player1Damage(int value)
    {
        cardinfo.player1Hp -= value;
        player1Hp.fillAmount = (float)((float)cardinfo.player1Hp / (float)cardinfo.player1HpMax);

        if (cardinfo.player1Hp <= 0)
        {
            //フェードアウトしてリザルト画面
            changeScene.change_Scene();
        }
        else
        {
            cardinfo.Player1Flag = 1;
            cardinfo.Player2Flag = 0;
            for (int i = 0; i < 8; i++)
            {
                handCard1.transform.GetChild(i).transform.localScale = Vector3.one;
                handCard2.transform.GetChild(i).transform.localScale = Vector3.one;
                handCard1.transform.GetChild(i).transform.position += Vector3.down * 0.3f;
                handCard2.transform.GetChild(i).transform.position += Vector3.down * 0.3f;
            }
            timeManager.StartCard();
        }
    }
    
    private void Player2Damage(int value)
    {
        cardinfo.player2Hp -= value;
        player2Hp.fillAmount = (float)((float)cardinfo.player2Hp / (float)cardinfo.player2HpMax);

        if (cardinfo.player2Hp <= 0)
        {
            //フェードアウトしてリザルト画面
            changeScene.change_Scene();
        }
        else
        {
            cardinfo.Player1Flag = 0;
            cardinfo.Player2Flag = 1;
            for (int i = 0; i < 8; i++)
            {
                handCard1.transform.GetChild(i).transform.localScale = Vector3.one;
                handCard2.transform.GetChild(i).transform.localScale = Vector3.one;
                handCard1.transform.GetChild(i).transform.position += Vector3.down * 0.3f;
                handCard2.transform.GetChild(i).transform.position += Vector3.down * 0.3f;
                
            }
            timeManager.StartCard();
        }
    }

    public void InitHP()
    {
        cardinfo.player1HpMax = 100;
        cardinfo.player2HpMax = 100;
        cardinfo.player1Hp = cardinfo.player1HpMax;
        cardinfo.player2Hp = cardinfo.player2HpMax;
    }
}
