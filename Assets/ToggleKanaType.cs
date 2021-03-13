using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ToggleKanaType : MonoBehaviour
{
    public KanaGrid KanaGrid;
    public Text Text;
    public string TextWhenHiragana;
    public string TextWhenKatakana;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (KanaGrid.KanaType)
        {
            default:
                break;
            case KanaGrid.EKanaType.Hiragana:
                Text.text = TextWhenHiragana;
                break;
            case KanaGrid.EKanaType.Katakana:
                Text.text = TextWhenKatakana;
                break;
        }
    }
}
