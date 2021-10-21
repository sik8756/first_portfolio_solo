using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lucia : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Pattern = new List<GameObject>();

    [SerializeField]
    GameObject Wall;
    Vector2 OriginPos;
    Vector2 OriginPos2;

    void Start()
    {
        OriginPos = Pattern[0].transform.localPosition;
        OriginPos2 = Pattern[2].transform.localPosition;
    }

    public IEnumerator StartPattern()
    {
        Pattern[0].transform.localPosition = OriginPos;
        Pattern[2].transform.localPosition = OriginPos2;
        yield return new WaitForSeconds(2);
        Wall.SetActive(true);

        StartCoroutine(Pattern[1].GetComponent<metal>().StartPattern());

        StartCoroutine(Pattern[0].GetComponent<Pattern1>().Move());
        StartCoroutine(Pattern[2].GetComponent<Pattern2>().Move());


        yield return new WaitForSeconds(21);

        StartCoroutine(Pattern[0].GetComponent<Pattern1>().Stop());
        StartCoroutine(Pattern[1].GetComponent<metal>().Stop());
        StartCoroutine(Pattern[2].GetComponent<Pattern2>().Stop());

        StartCoroutine(Pattern[0].GetComponent<Pattern1>().reset());
        StartCoroutine(Pattern[2].GetComponent<Pattern2>().reset());
        yield return new WaitForSeconds(1.5f);
        Wall.SetActive(false);
        yield return null;
    }

}
