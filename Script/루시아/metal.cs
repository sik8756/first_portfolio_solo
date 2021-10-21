using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metal : MonoBehaviour
{
    AudioSource Aud;
    [SerializeField]
    GameObject LeftWWW;
    [SerializeField]
    GameObject RightWWW;

    private void Start()
    {
        Aud = GetComponent<AudioSource>();
    }



    public IEnumerator StartPattern()
    {

        Aud.Play();
        yield return new WaitForSeconds(2);
        StartCoroutine(repeat());



        yield return null;
    }

    IEnumerator repeat()
    {
        yield return new WaitForSeconds(0.95f);
        int ran;
        ran = Random.Range(0, 2);
        //왼쪽
        if(ran == 0)
        {
            Instantiate(LeftWWW, transform.position, Quaternion.identity);
        }
        //오른쪽
        if(ran == 1)
        {
            Instantiate(RightWWW, transform.position, Quaternion.identity);
        }

        StartCoroutine(repeat());
        yield return null;
    }

    public IEnumerator Stop()
    {
        StopAllCoroutines();
        yield return null;
    }
}
