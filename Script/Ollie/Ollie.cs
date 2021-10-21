using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ollie : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Pattren = new List<GameObject>();
    [SerializeField]
    List<GameObject> Wall = new List<GameObject>();
    Vector2 originPos;

    private void Start()
    {
        originPos = Pattren[0].transform.position;
    }


    public IEnumerator OllieStartCoroutine()
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < Wall.Count; i++)
        {
            Wall[i].SetActive(true);
        }
        Pattren[1].SetActive(true);
        yield return new WaitForSeconds(2);
        Pattren[1].SetActive(false);
        yield return StartCoroutine(Pattren[0].GetComponent<firstOllie>().first());
        Pattren[0].GetComponent<SpriteRenderer>().flipX = true;
        Pattren[2].SetActive(true);
        Pattren[0].transform.position = new Vector2(-25.6f, 2.4f);
        yield return new WaitForSeconds(1.5f);
        Pattren[2].SetActive(false);
        yield return StartCoroutine(Pattren[0].GetComponent<firstOllie>().Second());
        Pattren[0].GetComponent<SpriteRenderer>().flipX = false;
        Pattren[0].transform.position = originPos;

        for (int i = 0; i < Wall.Count; i++)
        {
            Wall[i].SetActive(false);
        }
        Debug.Log("끝남");

        yield return null;

    }

}
