using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class OptionButton : MonoBehaviour
{
    [Header("�������ԣ����޸�")]
    public Text text;
    public string content;

    [Header("��������")]
    public bool isRightAnswer = false;
    public bool isWrongAnser
    {
        get => !isRightAnswer;
    }

    public bool isChecked = false;
    public bool isNOTChecked
    {
        get => isChecked;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        //text.text = gameObject.name;
#endif
        text.text = content;

    }

    /*
    public void Reset()
    {
        isRightAnswer = false;
        isChecked = false;
    }
    */

    public void SetRightAnswer(string answer)
    {
        content = answer;
        isRightAnswer = true;
        isChecked = false;
        text.text = answer;
    }
    public void SetWrongAnswer(string answer)
    {
        content = answer;
        isRightAnswer = false;
        isChecked = false;
        text.text = answer;
    }

    /// <summary>
    /// �ж�����
    /// </summary>
    public void Judge()
    {
        Debug.Log($"������ȷ����{isRightAnswer}");
    }
}
