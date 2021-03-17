using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

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

    public AudioSource audioSource;
    public AudioClip audioWhenRight;
    public AudioClip audioWhenWrong;
    public AudioClip audioWhenNewQuestion;

    [Header("��ѡ��İ�ť")]
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
    /// �𰸵���ʾ
    /// </summary>
    public Text aTip;
    public string tip
    {
        get => aTip.text;
        set => aTip.text = value;
    }

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

    public void NewQuestion()
    {
        aText.enabled = false;
        aTip.enabled = false;
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
        tip = list[0].RandomTip().First();
        //optionsShuffled[0].SetRightAnswer(list[0].a);

        ///��ֵ������
        for (var i = 0; i < optionButtons.Count; i++)
        {
            optionsShuffled[i].SetOptionContent(list[i].a);
        }
    }

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
            Debug.Log($"���⣡{choice}");
            scoreModule.ScoreIncreaseBy(100);
            audioSource.clip = audioWhenRight;
            audioSource.Play();
        }
        else
        {
            Debug.Log($"����ȷ��{choice}");
            audioSource.clip = audioWhenWrong;
            audioSource.Play();
        }

        for (var i = 0; i < optionButtons.Count; i++)
        {
            var button = optionButtons[i];
            ///������ť����ֹ������
            button.LockButton();
        }
    }
}
