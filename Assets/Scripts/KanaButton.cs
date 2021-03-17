using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class KanaButton : MonoBehaviour
{
    /// <summary>
    /// 子物体的文字组件
    /// </summary>
    public Text Text;

    void Update()
    {
        Text.text = gameObject.name;
    }
}
