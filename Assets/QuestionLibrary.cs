using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class QuestionLibrary : MonoBehaviour
{
    [Header("出题的文本区")]
    public Text questionText;
    [Header("可选项的按钮")]
    public OptionGroup optionButtonsGroup;
    [Header("预定义的问题")]
    public List<AnswerTip> answers;

    System.Random rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewQuestion()
    {
        ///打乱自身
        var answersShuffled = answers.OrderBy(item => rand.Next()).ToList();
        ///根据选项的数量进行出题，填满
        var list = new List<AnswerTip>(optionButtonsGroup.children.Count);
        for (var i = 0; i < list.Capacity; i++)
        {
            answers[i].RandomQA();

            list.Add(answers[i]);
        }
        ///对题目进行赋值
        questionText.text = list[0].q;
        ///打乱选项
        var optionsShuffled = optionButtonsGroup.children.OrderBy(item => rand.Next()).ToList();
        ///赋值正确项
        optionButtonsGroup.children[0].SetRightAnswer(list[0].a);

        ///赋值错误项
        for (var i = 1; i < optionButtonsGroup.children.Count; i++)
        {
            optionButtonsGroup.children[i].SetWrongAnswer(list[i].a);
        }
    }
}
