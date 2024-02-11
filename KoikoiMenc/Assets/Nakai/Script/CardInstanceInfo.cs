using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInstanceInfo : MonoBehaviour
{
    public List<int> Cards = new List<int>();
    public int Player1Flag = 0;
    public int Player2Flag = 0;
    public Cardmean CardBefore;
    public Cardmean CardAfter;
    public int player1Hp;
    public int player1HpMax;
    public int player2Hp;
    public int player2HpMax;
    private void Start()
    {
       for (int i = 1; i <= 48; i++)
       {
            Cards.Add(i);
       }
    }
}
