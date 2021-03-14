using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Enermy : MonoBehaviour
{
    public GameObject h;
    public float angle;
    public Vector3 axis;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        h.transform.Rotate(axis, angle * Time.deltaTime);
    }
}
