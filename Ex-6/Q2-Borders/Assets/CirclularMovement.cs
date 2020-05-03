using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CirclularMovement : MonoBehaviour
{
    [SerializeField] Boolean isVertical = true;
    [SerializeField] float offset = (float)0.85;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Vector3 vec = collision.gameObject.transform.position;
            if (isVertical)
                vec.y = addBySign(vec.y);
            else
                vec.x = addBySign(vec.x);

            collision.gameObject.transform.position = vec;
        }
    }

    private float addBySign(float n)
    {
        float res = Math.Abs(n) - offset;
        return n < 0 ? res : -res;
    }
}
