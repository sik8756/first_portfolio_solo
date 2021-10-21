using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korone : MonoBehaviour
{
    [SerializeField]
    GameObject Player;

    [SerializeField]
    Vector2 MarioPos;
    Vector2 PlayerOriginPos;
    [SerializeField]
    GameObject Turtle;
    [SerializeField]
    GameObject Wall;
    AudioSource Aud;
    [SerializeField]
    List <AudioClip> Auc = new List<AudioClip>();
    [SerializeField]
    GameObject Danger;
    [SerializeField]
    GameObject Mario;
    [SerializeField]
    GameObject Fireboll;

    [SerializeField]
    Transform StartPos;
    [SerializeField]
    Transform EndPos;
    [SerializeField]
    Transform MarioMovePos;
    private void Start()
    {
        MarioPos = Mario.transform.position;
        PlayerOriginPos = new Vector2(-0.83f, -7.807f);
        Aud = GetComponent<AudioSource>();
    }


    public IEnumerator Pattern()
    {
        Danger.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Danger.SetActive(false);
        StartCoroutine(change(0));
        Turtle.SetActive(true);
        StartCoroutine(Turtle.GetComponent<turtle>().Pattern(StartPos, EndPos, 2));
        yield return new WaitForSeconds(2f);

        StartCoroutine(change(1));
        StartCoroutine(start());
        yield return new WaitForSeconds(2);
        StartCoroutine(change(2));
        StartCoroutine(Turtle.GetComponent<turtle>().reversePattern(StartPos, EndPos, 2));
        yield return new WaitForSeconds(2);
        StartCoroutine(Mario.GetComponent<Mario>().Move(MarioPos,MarioMovePos,1));
        yield return new WaitForSeconds(2);
        StartCoroutine(Mario.GetComponent<Mario>().Fire(Auc[3],Fireboll));
        yield return new WaitForSeconds(100);
        yield return null;
    }

    IEnumerator change(int number)
    {
        Aud.clip = Auc[number];
        Aud.Play();
        yield return null;
    }

    IEnumerator start()
    {
        Wall.SetActive(true);
        Player.transform.position = PlayerOriginPos;

        yield return null;
    }
}
