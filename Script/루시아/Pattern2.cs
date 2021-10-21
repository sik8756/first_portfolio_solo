using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern2 : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    Transform Botteum;
    [SerializeField]
    Transform Up;

    Vector2 originPos;

    AudioSource Aud;

    private void Start()
    {
        originPos = transform.localPosition;
        Aud = GetComponent<AudioSource>();
    }
    public IEnumerator Move()
    {
        yield return new WaitForSeconds(Random.Range(2, 6));
        speed = 5;
        while (gameObject.transform.localPosition.x >= Botteum.transform.localPosition.x)
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0));
            yield return null;
        }

        while (gameObject.transform.localPosition.y >= Botteum.transform.localPosition.y)
        {
            transform.Translate(new Vector2(0, -speed * Time.deltaTime));
            yield return null;
        }

        yield return StartCoroutine(Move2());
        yield return null;
    }

    IEnumerator Move2()
    {
        speed = 50;
        Aud.Play();
        yield return new WaitForSeconds(1);
        while (gameObject.transform.localPosition.y <= Up.transform.localPosition.y)
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, speed * Time.deltaTime));
            yield return null;
        }
        yield return new WaitForSeconds(1);
        gameObject.transform.localPosition = originPos;
        StartCoroutine(Move());
        yield return null;
    }
    public IEnumerator Stop()
    {
        StopAllCoroutines();
        yield return null;
    }
    public IEnumerator reset()
    {
        gameObject.transform.localPosition = originPos;
        yield return null;
    }
}
