using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peko : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Pattern = new List<GameObject>();
    AudioSource Aud;
    GameObject Camera;

    [SerializeField]
    float burglar;
    [SerializeField]
    float time;
    private void Start()
    {
        Aud = GetComponent<AudioSource>();
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }





    public IEnumerator StartPattern()
    {
        Aud.Play();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Pattern[0].GetComponent<rabbit>().StartPattern());
        StartCoroutine(Pattern[1].GetComponent<bigrabbit>().Pattern());
        yield return new WaitForSeconds(5);
        StartCoroutine(Pattern[2].GetComponent<carrotPeko>().Pattern());
        yield return new WaitForSeconds(4);
        StartCoroutine(Camera.GetComponent<Camera>().Shake(burglar, time));
        yield return new WaitForSeconds(5);
        StopAllCoroutines();
        StartCoroutine(Camera.GetComponent<Camera>().reset());
        yield return null;
    }

}
