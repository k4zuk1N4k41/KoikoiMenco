using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    /// <summary>
    /// �Q�[���I���֐�
    /// </summary>
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        //���̃R�[�h�Ńr���h�����Q�[�����I�����邱�Ƃ��ł���
        Application.Quit();
#endif
    }
}
