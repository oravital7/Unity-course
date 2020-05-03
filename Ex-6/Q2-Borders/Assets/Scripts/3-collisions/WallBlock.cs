using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBlock : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
            gameObject.GetComponent<KeyboardMover>().isBlocked = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
            gameObject.GetComponent<KeyboardMover>().isBlocked = false;
    }
}
