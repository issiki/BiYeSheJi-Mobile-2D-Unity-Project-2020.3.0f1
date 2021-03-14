using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class KanaUICard : MonoBehaviour
{
    [Header("ÂÞÂí×Ö")]
    public string romaji = "a";
    //public Text romajiText;
    [Header("¼ÙÃûÍ¼Æ¬")]
    public Sprite hiragana;
    public Sprite katakana;
    //public SpriteRenderer kanaRenderer;
    [Header("±ÊË³Í¼Æ¬")]
    public Sprite hiraStroke;
    public Sprite kataStroke;
    //public SpriteRenderer strokeRenderer;
    [Header("À´Ô´")]
    public Sprite hiraDev;
    public Sprite kataDev;
    //public SpriteRenderer devRenderer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        romaji = gameObject.name;
    }
}
