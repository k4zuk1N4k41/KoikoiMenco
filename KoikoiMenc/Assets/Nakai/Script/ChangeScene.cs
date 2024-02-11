using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string scene;
    [SerializeField] private GameObject transitionPrefab;

    readonly float waitTime = 1.0f;

    public void change_Scene()
    {
        StartCoroutine(nameof(LoadScene));
    }

    IEnumerator LoadScene()
    {
        Instantiate(transitionPrefab);
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(scene);
    }
}
