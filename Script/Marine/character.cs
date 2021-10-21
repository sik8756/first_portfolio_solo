using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    Rigidbody2D RB;
    AudioSource Aud;
    void Start()
    {
        Aud = GetComponent<AudioSource>();
        RB = GetComponent<Rigidbody2D>();

        up();
    }

    void up()
    {
        RB.AddForce(new Vector2(0, 1250));

        Invoke("Death", 3f);
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
