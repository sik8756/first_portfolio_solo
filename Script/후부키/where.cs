using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class where : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Danger = new List<GameObject>();
    [SerializeField]
    List<GameObject> hit = new List<GameObject>();
    [SerializeField]
    GameObject Left;
    [SerializeField]
    GameObject Right;
    AudioSource Aud;

    void Start()
    {
        Aud = GetComponent<AudioSource>();
    }

    public IEnumerator Pattern()
    {
        for (int repeat = 1; repeat < 5; repeat++)
        {
            Aud.Play();
            int ran, ran2;
            ran = Random.Range(0, 2);
            ran2 = Random.Range(0, 2);
            Danger[ran].SetActive(true);
            if (ran2 == 0)
            {
                Right.SetActive(true);
            }
            else if (ran2 == 1)
            {
                Left.SetActive(true);
            }
            yield return new WaitForSeconds(2.75f - (repeat * 0.5f));
            Left.SetActive(false);
            Right.SetActive(false);
            PlayerMove.move = true;
            if (ran2 == 0)
            {
                hit[0].SetActive(true);
            }
            else if (ran2 == 1)
            {
                hit[1].SetActive(true);
            }
            yield return new WaitForSeconds(0.7f);
            PlayerMove.move = false;
            Danger[ran].SetActive(false);
            hit[0].SetActive(false);
            hit[1].SetActive(false);
            yield return new WaitForSeconds(1);
        }

        yield return null;
    }
}
