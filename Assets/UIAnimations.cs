using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UIAnimations : MonoBehaviour
{
    public GameObject KanaGrid;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void �л���ʾ���ؼ�����ť����()
    {
        KanaGrid.SetActive(!KanaGrid.activeInHierarchy);
    }
}
