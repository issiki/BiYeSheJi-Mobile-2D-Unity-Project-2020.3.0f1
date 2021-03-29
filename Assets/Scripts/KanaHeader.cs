using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class KanaHeader : MonoBehaviour
{
    public Text Text;

    void Update()
    {
        Text.text = gameObject.name;
    }
}
