using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[ExecuteInEditMode]
public class SceneController : MonoBehaviour
{
    //public Scene mainScene;
    //public Scene ��ѡ����ϰ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ת��������()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void ת����ϰ����()
    {
        SceneManager.LoadScene("��ѡ����ϰ");
    }

    public void �˳�����()
    {
#if UNITY_EDITOR
        ///�༭��״̬�½���Play
        UnityEditor.EditorApplication.isPlaying = false;
#else
///����״̬�£��˳�����
        Application.Quit();
#endif
    }
}
