using System.Collections;
using UnityEngine;

public class Face : MonoBehaviour
{
    AudioSource Aud;
    Rigidbody2D RB;
    Vector2 originPos;
    void Start()
    {
        Aud = GetComponent<AudioSource>();
        RB = GetComponent<Rigidbody2D>();
        originPos = gameObject.transform.localPosition;
    }

    public IEnumerator Pattern()
    {
        
        gameObject.transform.localPosition = originPos;
        yield return null;
        StartCoroutine(Move());
        Aud.Play();

        yield return null;
    }

    IEnumerator Move()
    {
        int ran1, ran2 = 0;

        ran1 = Random.Range(-1, 2);
        while(ran1 == 0)
        {
            ran1 = Random.Range(-1, 2);
        }
        ran2 = Random.Range(-1, 2);
        while(ran2 == 0)
        {
            ran2 = Random.Range(-1, 2);
        }
        RB.AddForce(new Vector2(ran1, ran2)*750);
        yield return null;
    }
}
