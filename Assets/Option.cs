using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    [Header("自身")]
    public Collider2D collider2d;
    [Header("是否正解")]
    public bool isRightAnswer = false;
    public bool isWrongAnswer
    {
        get => !isRightAnswer;
    }
    public bool isChecked = false;
    public bool isNotChecked
    {
        get => !isChecked;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
