using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitedTimeChoiceQuestion : MonoBehaviour
{
    public float limitedSeconds;
    float _timeLeft;
    public List<Option> options;
    public Text countDown;
    bool isCountingDown = true;
    // Start is called before the first frame update
    void Start()
    {
        _timeLeft = limitedSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        countDown.text = $"{_timeLeft:2}s";
    }

    private void FixedUpdate()
    {
        if (_timeLeft < 0 || !isCountingDown)
        {
            return;
        }
        ///����ʱ
        //if (isCountingDown)
        //{
        _timeLeft -= Time.deltaTime;
        //}
    }

    /// <summary>
    /// ���н������ʱ�����ʱ���û���������
    /// </summary>
    public void Judge()
    {
        StopCountingDown();

        options.ForEach(delegate (Option op)
        {
            if ((op.isChecked && op.isWrongAnswer) || (op.isNotChecked && op.isRightAnswer))
            {
                Bad();
                return;
            }
        });

        Good();
    }

    public void Bad()
    {
        Debug.Log("δȫ��");
    }

    public void Good()
    {
        Debug.Log("ȫ����");
    }

    public void StopCountingDown()
    {
        isCountingDown = false;
    }
}
