using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class KanaButton : MonoBehaviour
{
    /// <summary>
    /// 子物体的文字组件
    /// </summary>
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = transform.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = gameObject.name;
    }
}
