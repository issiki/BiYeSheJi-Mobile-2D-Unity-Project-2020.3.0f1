using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class KanaButton : MonoBehaviour
{
    /// <summary>
    /// ��������������
    /// </summary>
    public Text Text;

    void Update()
    {
        Text.text = gameObject.name;
    }
}
