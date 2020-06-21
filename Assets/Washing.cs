using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Washing : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "plant")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "wheat")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "sapling")
        {
            Destroy(collision.gameObject);
        }
    }
}
