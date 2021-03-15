using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ScoreModule : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        ///��ȡ�洢�ĵ÷�
        score = PlayerPrefs.GetInt("Score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"{score}";
    }

    void ScoreIncreaseBy(int more)
    {
        score += more;
        SaveScore();
    }

    void SaveScore()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
    }
}
