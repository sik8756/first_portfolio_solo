using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whereareyoulooking : MonoBehaviour
{
    SpriteRenderer SR;
    AudioSource Aud;
    BoxCollider2D BC;
    void Start()
    {
        BC = GetComponent<BoxCollider2D>();
        Aud = GetComponent<AudioSource>();
        SR = GetComponent<SpriteRenderer>();
    }

    public IEnumerator Pattern()
    {
        Aud.Play();
        SR.color = new Color(1, 1, 1, 1);
        BC.enabled = true;
        yield return new WaitForSeconds(0.25f);
        BC.enabled = false;
        StartCoroutine(Delete());
        yield return null;
    }
    
    IEnumerator Delete()
    {
        float time = 0;
        while(time <= 1.5f)
        {
            time += Time.deltaTime / 1.5f;
            SR.color = new Color(1, 1, 1, Mathf.Lerp(1,0,time));
            yield return null;
        }      
        yield return null;
    }
}
