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
    public Text Text;
    // Start is called before the first frame update
    void Start()
    {
        //Text = transform.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = gameObject.name;
    }
}
