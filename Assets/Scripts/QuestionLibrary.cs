using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class QuestionLibrary : MonoBehaviour
{
    public ScoreModule scoreModule;
    [Header("������ı���")]
    public Text questionText;
    public string q
    {
        get => questionText.text;
        set => questionText.text = value;
    }

    [Header("��ѡ��İ�ť")]
    //public OptionGroup optionButtonsGroup;
    public List<OptionButton> optionButtons;

    //public string q;
    public string a;

    [Header("Ԥ��������")]
    public List<AnswerTip> library;

    /// <summary>
    /// �����
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
        ///����ѡ�ť
        for (var i = 0; i < optionButtons.Count; i++)
        {
            optionButtons[i].UnlockButton();
        }

        ///�������
        var libraryShuffled = library.OrderBy(item => rand.Next()).ToList();

        ///����ѡ�������׼����Ŀ
        var tempList = new List<AnswerTip>(optionButtons.Count);
        for (var i = 0; i < tempList.Capacity; i++)
        {
            ///��Ŀ�Ѿ�����
            libraryShuffled[i].RandomQA();

            tempList.Add(libraryShuffled[i]);
        }

        ///����
        var list = tempList.OrderBy(item => rand.Next()).ToList();
        ///����Ŀ���и�ֵ
        q = list[0].q;
        ///����ѡ��
        var optionsShuffled = optionButtons.OrderBy(item => rand.Next()).ToList();
        ///��ֵ��ȷ��
        a = list[0].a;
        //optionsShuffled[0].SetRightAnswer(list[0].a);

        ///��ֵ������
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
            ///������ť����ֹ������
            button.LockButton();

            if (button.isChecked)
            {
                if (button.content == a)
                {
                    //button.Right();
                    Debug.Log("ѡ������ȷ�Ĵ�");
                }
                else
                {
                    //button.Wrong();
                    Debug.Log("ѡ���˴���Ĵ�");
                }
            }
            else
            {
                // button.NotCheck();
                Debug.Log("û��ѡ�����");
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
        if (choice == a)
        {
            Debug.Log($"���⣡{choice}");
            scoreModule.ScoreIncreaseBy(100);
        }
        else
        {
            Debug.Log($"����ȷ��{choice}");
        }

        for (var i = 0; i < optionButtons.Count; i++)
        {
            var button = optionButtons[i];
            ///������ť����ֹ������
            button.LockButton();

            /*
            if (button.isChecked)
            {
                if (button.content == a)
                {
                    //button.Right();
                    Debug.Log("ѡ������ȷ�Ĵ�");
                }
                else
                {
                    //button.Wrong();
                    Debug.Log("ѡ���˴���Ĵ�");
                }
            }
            else
            {
                // button.NotCheck();
                Debug.Log("û��ѡ�����");
            }
            */
        }
    }
}
