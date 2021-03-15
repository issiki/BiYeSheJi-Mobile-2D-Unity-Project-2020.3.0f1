using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

[ExecuteInEditMode]
public class AnswerTip : MonoBehaviour
{
    //public string question;
    /// <summary>
    /// ȫ������ȷ�𰸣������2�����Գ���
    /// </summary>
    [Header("�ֱ��Ӧ�����֡�ƽ������Ƭ����")]
    public List<string> answers;

    /// <summary>
    /// �������Ŀ
    /// </summary>
    [Header("�������ϵͳ�õ�Q��A")]
    public string q;

    /// <summary>
    /// ����Ĵ�
    /// </summary>
    public string a;

    /// <summary>
    /// ��������йص���ʾ
    /// </summary>
    [Header("���������ص���ʾ")]
    public List<string> tips;

    System.Random rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

#if UNITY_EDITOR
        if (answers.Count > 0)
        {
            answers[0] = gameObject.name;
        }
#endif

    }

    /*
    public IEnumerable<string> RandomQuestion()
    {
        if (answers.Count < 1)
        {
            yield return "";
        }
        var randIndex = rand.Next(0, answers.Count);
        yield return answers[randIndex];
    }
    */

    /// <summary>
    /// �����q��a����
    /// </summary>
    public void RandomQA()
    {
        ///��������
        var list = answers.OrderBy(item => rand.Next()).ToList();
        ///��ǰ����ֵ��ֵ��q��a
        q = list[0];
        a = list[1];
    }

    public IEnumerable<string> RandomTip()
    {
        if (tips.Count < 1)
        {
            yield return "";
        }
        var randIndex = rand.Next(0, tips.Count);
        yield return tips[randIndex];
    }
}
