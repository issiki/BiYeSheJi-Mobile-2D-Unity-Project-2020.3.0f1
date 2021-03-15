using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class PlayButton : MonoBehaviour
{
    public Sprite play;
    public Button button;
    //public Sprite pause;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        button.image.sprite = play;
    }
}
