using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class StrokeHit : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[] elements;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var circles = GetComponentsInChildren<StrokeCircle>();

        if (circles == null)
        {
            SpawnChildren(0, elements.Length);
            return;
        }
        else
        {

            /// 4 < 5
            var childCount = circles.Length;
            var expectedChildrenCount = elements.Length;
            if (childCount < expectedChildrenCount)
            {
                SpawnChildren(childCount, expectedChildrenCount);
            }
        }
        ///重新给子元素起名
        var length = elements.Length;
        for (var i = 0; i < length; i++)
        {
            elements[i].name = $"{gameObject.name} ({i})";
        }
    }

    void SpawnChildren(int indexStart, int indexEnd)
    {
        for (var i = indexStart; i < indexEnd; i++)
        {
            var child = Instantiate(prefab, transform);
            ///重置位置
            child.transform.position = transform.position;
            ///挂载给自己
            //child.transform.parent = transform;
            elements[i] = child;
        }
    }
}
