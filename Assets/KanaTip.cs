using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class KanaTip : MonoBehaviour
{
    public List<string> tips;

    System.Random rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public string RandomTip()
    {
        var randIndex = rand.Next(0, tips.Count);
        return tips[randIndex];
    }
}
