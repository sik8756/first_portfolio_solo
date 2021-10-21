using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstOllie : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    List<Transform> Pos = new List<Transform>();

    public bool check;
    AudioSource Aud;
    private void Start()
    {
        Aud = GetComponent<AudioSource>();
    }

    public IEnumerator first()
    {

        check = false;
        Aud.Play();
        while (!check)
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0));

            if (gameObject.transform.localPosition.x <= Pos[0].transform.localPosition.x)
            {
                check = true;
            }
            yield return null;
        }
        yield return null;
    }

    public IEnumerator Second()
    {
        check = false;
        Aud.Play();
        while (!check)
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0));

            if (gameObject.transform.localPosition.x >= Pos[1].transform.localPosition.x)
                check = true;

            yield return null;
        }

        yield return null;
    }

}
