using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    AudioSource Aud;
    Animator Ani;
    private void Start()
    {
        Aud = GetComponent<AudioSource>();
        Ani = GetComponent<Animator>();
    }

    public IEnumerator Move(Vector2 start, Transform MarioEndPos, float time)
    {
        Vector2 EndPos = MarioEndPos.transform.position;
        gameObject.transform.position = start;
        float timer = 0;
        while(gameObject.transform.position.x <= EndPos.x-0.05)
        {
            timer += Time.deltaTime / time;

            transform.position = new Vector2(Mathf.Lerp(start.x, EndPos.x, timer),EndPos.y);

            yield return null;
        }
        StartCoroutine(Stop());
        
        yield return null;
    }

    IEnumerator Stop()
    {
        Ani.SetTrigger("Stop");
        yield return null;
    }

    public IEnumerator Fire(AudioClip A, GameObject Fireboll)
    {
        Aud.clip = A;
        Aud.Play();
        Ani.SetTrigger("Bullet");
        yield return null;
    }
}
