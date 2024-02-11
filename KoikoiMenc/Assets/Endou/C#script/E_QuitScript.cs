using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_QuitScript : MonoBehaviour
{
    /// <summary>
    /// ゲーム終了関数
    /// </summary>
    public void Quit()
    {
        E_Quit();

    }
    private void E_Quit()
    {
        StartCoroutine(E_quit());
    }

    private IEnumerator E_quit()
    {
        yield return new WaitForSeconds(1);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        //このコードでビルドしたゲームを終了することができる
        Application.Quit();
#endif
    }
}
