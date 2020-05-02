using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanObjects : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float yLocation = collision.gameObject.transform.position.y;

        if ((yLocation > 0 && collision.tag == "Laser") || (yLocation < 0 && collision.tag == "Enemy"))
            Destroy(collision.gameObject);
    }
}
