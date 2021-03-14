using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public Transform startingPoint;
    public Transform destination;
    public bool flying;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (flying)
        {
            var direction = destination.position - transform.position;
            if (direction.magnitude <= 1f)
            {
                transform.position = destination.position;
                rigidbody2d.velocity = Vector3.zero;
                return;
            }
            direction.Normalize();
            rigidbody2d.AddForce(direction * speed * Time.deltaTime);


        }
        else
        {
            rigidbody2d.velocity = Vector2.zero;
        }
    }

    public void Fly()
    {
        flying = true;
    }

    public void Restart()
    {
        transform.position = startingPoint.position;
        rigidbody2d.velocity = Vector2.zero;
        Fly();
    }

    public void StopFlying()
    {
        flying = false;
    }
}
