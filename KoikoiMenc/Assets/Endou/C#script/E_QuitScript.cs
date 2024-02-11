using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_QuitScript : MonoBehaviour
{
    /// <summary>
    /// �Q�[���I���֐�
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
        //���̃R�[�h�Ńr���h�����Q�[�����I�����邱�Ƃ��ł���
        Application.Quit();
#endif
    }
}
