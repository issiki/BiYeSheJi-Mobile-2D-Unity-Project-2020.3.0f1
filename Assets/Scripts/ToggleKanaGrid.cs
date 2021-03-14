using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ToggleKanaGrid : MonoBehaviour
{
    public GameObject[] GameObject;
    public Text Text;
    public string TextWhenActive;
    public string TextWhenInactive;
    bool visibility = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        Text.text = visibility ? TextWhenActive : TextWhenInactive;
#endif
    }

    public void Toggle()
    {
        visibility = !visibility;
        foreach (var obj in GameObject)
        {
            obj.SetActive(visibility);
        }
        Text.text = visibility ? TextWhenActive : TextWhenInactive;
    }
}
