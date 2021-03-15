using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
[ExecuteInEditMode]
public class OptionGroup : MonoBehaviour
{
    public OptionButton prefab;
    public List<OptionButton> children;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        /*
        var children = GetComponentsInChildren<OptionButton>();
        if (children == null)
        {
            SpawnButtons(0, this.children.Count);
        }
        else
        {
            if (children.Length < this.children.Count)
            {
                SpawnButtons(children.Length, this.children.Count);
            }
        }
        */

        ///RenameChildren();
#endif
    }

    void SpawnButtons(int startIndex, int endIndex)
    {
        for (var i = startIndex; i < endIndex; i++)
        {
            var child = OptionButton.Instantiate(prefab, transform);
            child.transform.position = transform.position;

            children[i] = child;
        }
    }

    /*
    void RenameChildren()
    {
        for (var i = 0; i < children.Count; i++)
        {
            children[i].name = $"{gameObject.name} ({i})";
        }
    }
    */
}
