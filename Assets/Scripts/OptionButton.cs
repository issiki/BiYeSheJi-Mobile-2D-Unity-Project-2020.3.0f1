using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class OptionButton : MonoBehaviour
{
    [Header("�������ԣ����޸�")]
    public Button button;
    public Text text;
    public string content
    {
        set => text.text = value;
        get => text.text;
    }
    //public bool isChecked = false;

    [Header("��������")]
    public Image image;

    /*
    public bool isRightAnswer = false;
    public bool isWrongAnser
    {
        get => !isRightAnswer;
    }
    */


    /*
    public bool isChecked = false;
    public bool isNOTChecked
    {
        get => isChecked;
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        //image.col
    }

    /*
    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        //text.text = gameObject.name;
#endif
        text.text = content;

    }
    */

    /*
    public void Reset()
    {
        isRightAnswer = false;
        isChecked = false;
    }
    */

    /*
    public void CheckThis()
    {
        isChecked = true;
    }

    public void UncheckThis()
    {
        isChecked = false;
    }
    */

    /*

    public void NotCheck()
    {
        image.color = Color.white;
    }

    public void Right()
    {
        image.color = Color.green;
    }

    public void Wrong()
    {
        image.color = Color.red;
    }
    */


    public void SetOptionContent(string optionContent)
    {
        content = optionContent;
        //isRightAnswer = true;
        //isChecked = false;
        //this.text.text = optionContent;
    }
    /*
    public void SetWrongAnswer(string answer)
    {
        content = answer;
        //isRightAnswer = false;
        //isChecked = false;
        text.text = answer;
    }
    */

    /*
    /// <summary>
    /// �ж�����
    /// </summary>
    public void Judge()
    {
        Debug.Log($"������ȷ����{isRightAnswer}");
    }
    */

    public void LockButton()
    {
        button.interactable = false;
    }

    public void UnlockButton()
    {
        button.interactable = true;
    }
}
