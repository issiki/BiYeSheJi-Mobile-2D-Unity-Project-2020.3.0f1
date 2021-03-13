using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode]
public class KanaCard : MonoBehaviour
{
    [Header("������")]
    public TextMesh RomajiTextMesh;
    [Header("����ͼƬ")]
    public Sprite KanaSprite;
    public SpriteRenderer KanaRenderer;
    [Header("��˳ͼƬ")]
    public Sprite StrokeSprite;
    public SpriteRenderer StrokeRenderer;

    ////public string Romaji;

    [Header("��ײ�������ڵ������")]
    /// <summary>
    /// ����ײ��
    /// </summary>
    public BoxCollider2D Collider2D;
    public float BoxColliderOffsetY = 3.5f;
    public float BoxColliderWidth = 1f;

    void Start()
    {
#if UNITY_EDITOR
        //KanaRenderer = transform.Find("Kana Sprite").GetComponent<SpriteRenderer>();
        //StrokeRenderer = transform.Find("Stroke Sprite").GetComponent<SpriteRenderer>();

        //var childTextMesh = transform.Find("Romaji Text Mesh");
        //RomajiTextMesh = childTextMesh.GetComponent<TextMesh>();
        //Collider2D = GetComponent<BoxCollider2D>();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        KanaRenderer.sprite = KanaSprite;
        StrokeRenderer.sprite = StrokeSprite;
        RomajiTextMesh.text = gameObject.name;

        var offset = Collider2D.offset;
        Collider2D.offset = new Vector2(offset.x, BoxColliderOffsetY);

        var size = Collider2D.size;
        Collider2D.size = new Vector2(BoxColliderWidth, size.y);
    }
}
