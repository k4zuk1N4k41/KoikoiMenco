using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject V_Result;
    [SerializeField] GameObject L_Result;
    [SerializeField] GameObject Draw_Result;
    public int FinalEnemy_HP;
    public int FinalPlayer_HP;
    int Final_Result;
    public AudioClip V_se;
    public AudioClip L_se;
    AudioSource audioSource0;
    void Start()
    {
        audioSource0 = GetComponent<AudioSource>();
    }


    public void result()
    {
        if ((FinalEnemy_HP == 0) && (FinalPlayer_HP == 0))
        {
            Draw_Result.SetActive(true);
        }
         else if (FinalEnemy_HP == 0)
        {
            V_Result.SetActive(true);
            audioSource0.PlayOneShot(V_se);
        }
        else if (FinalPlayer_HP == 0)
        {
            L_Result.SetActive(true);
            audioSource0.PlayOneShot(L_se);
        }
        else
        {
            Final_Result = FinalPlayer_HP - FinalEnemy_HP;
            if (Final_Result > 0)
            {
                V_Result.SetActive(true);
                audioSource0.PlayOneShot(V_se);
            }
            else if (Final_Result < 0)
            {
                L_Result.SetActive(true);
                audioSource0.PlayOneShot(L_se);
            }
            else
            {
                Draw_Result.SetActive(true);
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
