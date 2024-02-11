using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] GameObject V_Result;
    [SerializeField] GameObject L_Result;
    [SerializeField] GameObject Draw_Result;
    public void reset0()
    {
        Draw_Result.SetActive(false);
        V_Result.SetActive(false);
        L_Result.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
