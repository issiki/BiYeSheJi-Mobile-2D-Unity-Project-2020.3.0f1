using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class KanaHeader : MonoBehaviour
{
    public Text Text;
    // Start is called before the first frame update
    void Start()
    {
        //Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = gameObject.name;
    }
}
