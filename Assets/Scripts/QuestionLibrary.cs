using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class QuestionLibrary : MonoBehaviour
{
    public ScoreModule scoreModule;
    [Header("出题的文本区")]
    public Text questionText;
    public string q
    {
        get => questionText.text;
        set => questionText.text = value;
    }

    public AudioSource audioSource;
    public AudioClip audioWhenRight;
    public AudioClip audioWhenWrong;
    public AudioClip audioWhenNewQuestion;

    [Header("可选项的按钮")]
    //public OptionGroup optionButtonsGroup;
    public List<OptionButton> optionButtons;

    //public string q;
    public string a
    {
        get => aText.text;
        set => aText.text = value;
    }
    public Text aText;

    /// <summary>
    /// 答案的提示
    /// </summary>
    public Text aTip;
    public string tip
    {
        get => aTip.text;
        set => aTip.text = value;
    }

    [Header("预定义的题库")]
    public List<AnswerTip> library;

    /// <summary>
    /// 随机数
    /// </summary>
    System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        NewQuestion();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewQuestion()
    {
        aText.enabled = false;
        aTip.enabled = false;
        ///解锁选项按钮
        for (var i = 0; i < optionButtons.Count; i++)
        {
            optionButtons[i].UnlockButton();
        }

        ///打乱题库
        var libraryShuffled = library.OrderBy(item => rand.Next()).ToList();

        ///根据选项的数量准备题目
        var tempList = new List<AnswerTip>(optionButtons.Count);
        for (var i = 0; i < tempList.Capacity; i++)
        {
            ///题目已经乱序
            libraryShuffled[i].RandomQA();

            tempList.Add(libraryShuffled[i]);
        }

        ///打乱
        var list = tempList.OrderBy(item => rand.Next()).ToList();
        ///对题目进行赋值
        q = list[0].q;

        ///打乱选项
        var optionsShuffled = optionButtons.OrderBy(item => rand.Next()).ToList();
        ///赋值正确项
        a = list[0].a;
        tip = list[0].RandomTip().First();
        //optionsShuffled[0].SetRightAnswer(list[0].a);

        ///赋值错误项
        for (var i = 0; i < optionButtons.Count; i++)
        {
            optionsShuffled[i].SetOptionContent(list[i].a);
        }
    }

    /*
    public void Judge()
    {
        for (var i = 0; i < optionButtons.Count; i++)
        {
            var button = optionButtons[i];
            ///锁定按钮，防止继续点
            button.LockButton();

            if (button.isChecked)
            {
                if (button.content == a)
                {
                    //button.Right();
                    Debug.Log("选择了正确的答案");
                }
                else
                {
                    //button.Wrong();
                    Debug.Log("选择了错误的答案");
                }
            }
            else
            {
                // button.NotCheck();
                Debug.Log("没有选择此项");
            }
        }
    }
    */

    public void JudgeChoise(OptionButton optionButton)
    {
        JudgeChoise(optionButton.content);
    }

    public void JudgeChoise(string choice)
    {
        aText.enabled = true;
        aTip.enabled = true;


        if (choice == a)
        {
            Debug.Log($"正解！{choice}");
            scoreModule.ScoreIncreaseBy(100);
            audioSource.clip = audioWhenRight;
            audioSource.Play();
        }
        else
        {
            Debug.Log($"不正确！{choice}");
            audioSource.clip = audioWhenWrong;
            audioSource.Play();
        }

        for (var i = 0; i < optionButtons.Count; i++)
        {
            var button = optionButtons[i];
            ///锁定按钮，防止继续点
            button.LockButton();

            /*
            if (button.isChecked)
            {
                if (button.content == a)
                {
                    //button.Right();
                    Debug.Log("选择了正确的答案");
                }
                else
                {
                    //button.Wrong();
                    Debug.Log("选择了错误的答案");
                }
            }
            else
            {
                // button.NotCheck();
                Debug.Log("没有选择此项");
            }
            */
        }
    }
}
