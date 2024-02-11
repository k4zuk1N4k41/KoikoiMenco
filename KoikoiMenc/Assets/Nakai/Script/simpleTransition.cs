using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleTransition : MonoBehaviour
{
    readonly float waitTime = 2f;

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        StartCoroutine(nameof(Transition));
    }

    IEnumerator Transition()
    {
        yield return new WaitForSeconds(waitTime);

        Destroy(gameObject);
    }
}
