using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlegroundScroll : MonoBehaviour
{
    public float speed = 5f;
    public float width = 17.9f;
    void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);

        if (transform.position.x <= -width)
        {
            transform.position += new Vector3(width*2f, 0, 0);
        }
    }
}