using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cardjurge : MonoBehaviour
{
    [SerializeField] float value;
    [SerializeField] bool isOpen;

    [SerializeField] int Atk;

    // Update is called once per frame
    void Update()
    {
    }

    public void CardJurge()
    {
        if (value < 0.6f)
        {
            //0.6(60%)未満だった場合は、めくれない判定にする
            isOpen = false;
        }
        else
        {
            //0.6(60%)以上だった場合は、めくれる判定にする
            isOpen = true;

        }
    }
}
