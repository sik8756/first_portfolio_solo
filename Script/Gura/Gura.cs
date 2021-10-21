using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gura : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Pattren = new List<GameObject>();

    Vector2 first_originPos;

    private void Awake()
    {
        first_originPos = Pattren[0].transform.position;
    }



    public IEnumerator firstPattern()
    {
        yield return new WaitForSeconds(1.5f);
        Pattren[0].transform.localPosition = new Vector2(Pattren[0].transform.localPosition.x, 0);
        Pattren[0].GetComponent<Animove>().StartCoroutine(Pattren[0].GetComponent<Animove>().move());
        yield return new WaitForSeconds(5f);
        Pattren[0].transform.localPosition = first_originPos;
        Pattren[0].GetComponent<Animove>().StopAllCoroutines();
        StartCoroutine(Pattren[0].GetComponent<Animove>().reset());
        yield return StartCoroutine(SecondPattern());

        yield return StartCoroutine(thirdPattern());

        yield return null;
    }

    IEnumerator SecondPattern()
    {
        yield return StartCoroutine(Pattren[1].GetComponent<Poke>().StartPattern());
        Pattren[2].GetComponent<GuraCharacter>().StartCoroutine(Pattren[2].GetComponent<GuraCharacter>().DangerCoroutine());
        yield return new WaitForSeconds(1);      
        yield return null;
    }

    IEnumerator thirdPattern()
    {
        yield return StartCoroutine(Pattren[2].GetComponent<GuraCharacter>().StartPattern());
        yield return null;
    }

}
