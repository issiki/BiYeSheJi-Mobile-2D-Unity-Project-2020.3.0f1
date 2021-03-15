using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

[ExecuteInEditMode]
public class AnswerTip : MonoBehaviour
{
    /// <summary>
    /// 随机的题目
    /// </summary>
    [Header("题目")]
    public List<string> questions;

    /// <summary>
    /// 全都是正确答案，随机抽2个可以出题
    /// </summary>
    [Header("答案")]
    public List<string> answers;

    [Header("随机的题目和答案")]
    public string q;
    public string a;

    /// <summary>
    /// 随机的答案
    /// </summary>
    //public string[] a;

    /// <summary>
    /// 与这组答案有关的提示
    /// </summary>
    [Header("与这组答案相关的提示")]
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
        if (questions.Count > 0)
        {
            questions[0] = gameObject.name;
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
    /// 出题后，q和a可用
    /// </summary>
    public void RandomQA()
    {
        ///打乱自身,
        var list = answers.OrderBy(item => rand.Next()).ToList();
        a = list.First();
        ///打乱自身,
        var qList = questions.OrderBy(item => rand.Next()).ToList();
        q = qList.First();
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
