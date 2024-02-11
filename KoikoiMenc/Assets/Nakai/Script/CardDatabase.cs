using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardDatabase : ScriptableObject
{
    public List<CardData> cardDatas = new List<CardData>();
}
