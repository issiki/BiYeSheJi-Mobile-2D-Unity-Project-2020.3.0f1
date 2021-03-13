using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode]
public class KanaCard : MonoBehaviour
{
    public Sprite KanaSprite;
    SpriteRenderer _kanaRenderer;

    public Sprite StrokeSprite;
    SpriteRenderer _StrokeRenderer;

    ////public string Romaji;
    TextMesh _romajiTextMesh;

    public float BoxColliderOffsetY = 3.5f;
    public float BoxColliderWidth = 1f;
    /// <summary>
    /// ºÐÅö×²Æ÷
    /// </summary>
    BoxCollider2D _box;

    void Start()
    {
#if UNITY_EDITOR
        _kanaRenderer = transform.Find("Kana Sprite").GetComponent<SpriteRenderer>();
        _StrokeRenderer = transform.Find("Stroke Sprite").GetComponent<SpriteRenderer>();

        var childTextMesh = transform.Find("Romaji Text Mesh");
        _romajiTextMesh = childTextMesh.GetComponent<TextMesh>();
        _box = GetComponent<BoxCollider2D>();
#endif
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        _kanaRenderer.sprite = KanaSprite;
        _StrokeRenderer.sprite = StrokeSprite;
        _romajiTextMesh.text = gameObject.name;

        var offset = _box.offset;
        _box.offset = new Vector2(offset.x, BoxColliderOffsetY);

        var size = _box.size;
        _box.size = new Vector2(BoxColliderWidth, size.y);
    }
#endif
}
