using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class QuestionLibrary : MonoBehaviour
{
    [Header("������ı���")]
    public Text questionText;

    [Header("��ѡ��İ�ť")]
    public OptionGroup optionButtonsGroup;

    [Header("Ԥ���������")]
    public List<AnswerTip> answers;

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
        ///��������
        var answersShuffled = answers.OrderBy(item => rand.Next()).ToList();

        ///����ѡ����������г��⣬����
        var tempList = new List<AnswerTip>(optionButtonsGroup.children.Count);
        for (var i = 0; i < tempList.Capacity; i++)
        {
            answersShuffled[i].RandomQA();

            tempList.Add(answersShuffled[i]);
        }

        ///����
        var list = tempList.OrderBy(item => rand.Next()).ToList();
        ///����Ŀ���и�ֵ
        questionText.text = list[0].q;
        ///����ѡ��
        var optionsShuffled = optionButtonsGroup.children.OrderBy(item => rand.Next()).ToList();
        ///��ֵ��ȷ��
        optionsShuffled[0].SetRightAnswer(list[0].a);

        ///��ֵ������
        for (var i = 1; i < optionButtonsGroup.children.Count; i++)
        {
            optionsShuffled[i].SetWrongAnswer(list[i].a);
        }
    }
}
