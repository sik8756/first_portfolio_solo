using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckYou : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Fuck = new List<GameObject>();
    [SerializeField]
    List<GameObject> Danger = new List<GameObject>();

    List<Vector2> origin = new List<Vector2>();
    [SerializeField]
    float speed;
    public bool check;
    
    [SerializeField]
    Transform EndPos;
    [SerializeField]
    Transform StartPos;
    AudioSource Aud;

    private void Start()
    {
        Aud = GetComponent<AudioSource>();

        for (int Count = 0; Count < Fuck.Count; Count++)
        {
            origin.Add(Fuck[Count].transform.localPosition);
        }
    }

    public IEnumerator Up()
    {
        StartCoroutine(Up2());
        StartCoroutine(Up3());
        StartCoroutine(Up4());
        StartCoroutine(Up5());
        int random;

        random = Random.Range(0, Fuck.Count);
        Danger[random].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Danger[random].SetActive(false);
        Aud.Play();
        while(Fuck[random].transform.localPosition.y <= EndPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, speed * Time.deltaTime));
            yield return null;
        }

        yield return new WaitForSeconds(0.15f);

        while (Fuck[random].transform.localPosition.y >= StartPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, -speed * Time.deltaTime));
            yield return null;
        }

        if (check)
        {
            StartCoroutine(Up());
        }

        yield return null;
    }
    IEnumerator Up2()
    {
        int random;

        random = Random.Range(0, Fuck.Count);
        Danger[random].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Danger[random].SetActive(false);

        while (Fuck[random].transform.localPosition.y <= EndPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, speed * Time.deltaTime));
            yield return null;
        }

        yield return new WaitForSeconds(0.15f);

        while (Fuck[random].transform.localPosition.y >= StartPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, -speed * Time.deltaTime));
            yield return null;
        }
        yield return null;
    }
    IEnumerator Up3()
    {
        int random;

        random = Random.Range(0, Fuck.Count);
        Danger[random].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Danger[random].SetActive(false);

        while (Fuck[random].transform.localPosition.y <= EndPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, speed * Time.deltaTime));
            yield return null;
        }

        yield return new WaitForSeconds(0.15f);

        while (Fuck[random].transform.localPosition.y >= StartPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, -speed * Time.deltaTime));
            yield return null;
        }
        yield return null;
    }
    IEnumerator Up5()
    {
        int random;

        random = Random.Range(0, Fuck.Count);
        Danger[random].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Danger[random].SetActive(false);

        while (Fuck[random].transform.localPosition.y <= EndPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, speed * Time.deltaTime));
            yield return null;
        }

        yield return new WaitForSeconds(0.15f);

        while (Fuck[random].transform.localPosition.y >= StartPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, -speed * Time.deltaTime));
            yield return null;
        }
        yield return null;
    }
    IEnumerator Up4()
    {
        int random;

        random = Random.Range(0, Fuck.Count);
        Danger[random].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Danger[random].SetActive(false);

        while (Fuck[random].transform.localPosition.y <= EndPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, speed * Time.deltaTime));
            yield return null;
        }

        yield return new WaitForSeconds(0.15f);

        while (Fuck[random].transform.localPosition.y >= StartPos.transform.localPosition.y)
        {
            Fuck[random].transform.Translate(new Vector2(0, -speed * Time.deltaTime));
            yield return null;
        }
        yield return null;
    }

    public IEnumerator End()
    {
        for(int reset = 0; reset < Fuck.Count; reset++)
        {
            Danger[reset].SetActive(false);
        }

        for(int reset = 0; reset < Fuck.Count; reset++)
        {
            Fuck[reset].transform.localPosition = origin[reset];
        }
        yield return null;
    }


}
