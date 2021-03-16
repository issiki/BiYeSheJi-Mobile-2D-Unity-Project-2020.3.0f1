using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[ExecuteInEditMode]
public class SceneController : MonoBehaviour
{
    //public Scene mainScene;
    //public Scene 单选题练习;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void 转到主场景()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void 转到练习场景()
    {
        SceneManager.LoadScene("单选题练习");
    }

    public void 退出程序()
    {
#if UNITY_EDITOR
        ///编辑器状态下结束Play
        UnityEditor.EditorApplication.isPlaying = false;
#else
///运行状态下，退出程序
        Application.Quit();
#endif
    }
}
