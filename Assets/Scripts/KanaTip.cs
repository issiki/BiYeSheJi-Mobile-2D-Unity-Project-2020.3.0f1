using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class KanaTip : MonoBehaviour
{
    public List<string> tips;

    System.Random rand = new System.Random();
    public string RandomTip()
    {
        var randIndex = rand.Next(0, tips.Count);
        return tips[randIndex];
    }
}
