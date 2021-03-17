using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[ExecuteInEditMode]
public class AnswerTip : MonoBehaviour
{
    /// <summary>
    /// �������Ŀ
    /// </summary>
    [Header("��Ŀ")]
    public List<string> questions;

    /// <summary>
    /// ȫ������ȷ�𰸣������2�����Գ���
    /// </summary>
    [Header("��")]
    public List<string> answers;

    [Header("�������Ŀ�ʹ�")]
    public string q;
    public string a;

    /// <summary>
    /// ��������йص���ʾ
    /// </summary>
    [Header("���������ص���ʾ")]
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
    /// �����q��a����
    /// </summary>
    public void RandomQA()
    {
        ///��������,
        var list = answers.OrderBy(item => rand.Next()).ToList();
        a = list.First();
        ///��������,
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
