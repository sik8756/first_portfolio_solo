using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuraCharacter : MonoBehaviour
{
    Collider2D col;
    SpriteRenderer Spr;
    AudioSource AS;
    [SerializeField]
    GameObject Danger;
    [SerializeField]
    GameObject A;

    float time;
    bool Start;
    bool Stop;
    private void Awake()
    {
        col = GetComponent<Collider2D>();
        Spr = GetComponent<SpriteRenderer>();
        AS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Start)
        {
            time += Time.deltaTime / 2;
            Spr.color = new Color(1, 1, 1, Mathf.Lerp(0, 1, time));
        }

        if (Stop)
        {
            {
                time += Time.deltaTime / 2;
                Spr.color = new Color(1, 1, 1, Mathf.Lerp(1, 0, time));
            }
        }
    }

    public IEnumerator StartPattern()
    {
        Danger.SetActive(false);
        time = 0;
        Start = true;
        col.enabled = true;
        AS.Play();
        yield return new WaitForSeconds(2);
        Start = false;
        for (int produce = 0; produce < 100; produce++)
        {
            Instantiate(A, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
        col.enabled = false;
        StartCoroutine(StopCoroutine());
        yield return new WaitForSeconds(2);
        Stop = false;

        yield return null;
    }

    public IEnumerator DangerCoroutine()
    {
        Danger.SetActive(true);

        yield return null;
    }

    IEnumerator StopCoroutine()
    {
        time = 0;
        Stop = true;
        yield return null;
    }

}
