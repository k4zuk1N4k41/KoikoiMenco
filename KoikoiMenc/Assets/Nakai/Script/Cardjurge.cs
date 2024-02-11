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
            //0.6(60%)–¢–ž‚¾‚Á‚½ê‡‚ÍA‚ß‚­‚ê‚È‚¢”»’è‚É‚·‚é
            isOpen = false;
        }
        else
        {
            //0.6(60%)ˆÈã‚¾‚Á‚½ê‡‚ÍA‚ß‚­‚ê‚é”»’è‚É‚·‚é
            isOpen = true;

        }
    }
}
