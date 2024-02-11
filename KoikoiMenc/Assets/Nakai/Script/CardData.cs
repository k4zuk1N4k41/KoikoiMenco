using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[Serializable]
public class CardData
{
    public Sprite CardImage;     //絵柄
    public int Id;              //カードID
    public int Month;           //月
    public int point;           //ダメージ  
}
