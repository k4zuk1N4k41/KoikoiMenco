using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    /// <summary>
    /// ゲーム終了関数
    /// </summary>
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        //このコードでビルドしたゲームを終了することができる
        Application.Quit();
#endif
    }
}
