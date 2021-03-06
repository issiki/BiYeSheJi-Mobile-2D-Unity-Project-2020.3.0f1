using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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
    /// 与这组答案有关的提示
    /// </summary>
    [Header("与这组答案相关的提示")]
    public List<KanaTip> kanaTips;

    System.Random rand = new System.Random();

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
        if (kanaTips.Count < 1)
        {
            yield return "";
        }
        var randIndex = rand.Next(0, kanaTips.Count);
        yield return kanaTips[randIndex].RandomTip();
    }
}
