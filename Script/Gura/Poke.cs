using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poke : MonoBehaviour
{
    [SerializeField]
    GameObject danger;

    [SerializeField]
    Transform Player;

    AudioSource AS;
    bool down;
    bool StartCoroutineOn;
    int speed = 75;

    Vector2 originPos;
    private void Awake()
    {
        AS = GetComponent<AudioSource>();
        originPos = transform.position;
    }

    private void Update()
    {
        if(StartCoroutineOn && !down)
        transform.position = new Vector2(Player.transform.position.x, originPos.y);

        if(down)
        {
            transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        }


    }

    public IEnumerator StartPattern()
    {
        StartCoroutineOn = true;
        StartCoroutine(DangerOn());
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(DangerOff());
        yield return new WaitForSeconds(0.3f);
        //내려가기
        down = true;

        yield return StartCoroutine(repeat());
        transform.position = originPos;

        down = false;
        StartCoroutineOn = false;
        
        yield return null;
    }

    IEnumerator repeat()
    {
        for(int repeat = 0; repeat < 5; repeat++)
        {
            AS.Play();
            transform.position = new Vector2(Player.transform.position.x, originPos.y);
            yield return new WaitForSeconds(1);  
        }
        yield return null;
    }

    IEnumerator DangerOff()
    {
        danger.SetActive(false);
        yield return null;
    }

    IEnumerator DangerOn()
    {
        danger.SetActive(true);
        yield return null;
    }


}
