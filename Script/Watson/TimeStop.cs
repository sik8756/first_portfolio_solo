using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStop : MonoBehaviour
{
    [SerializeField]
    GameObject Panel;

    AudioSource Aud;
    public bool check;

    float time;
    private void Start()
    {
        Aud = GetComponent<AudioSource>();
    }

    public IEnumerator timestop()
    {
        
        yield return new WaitForSeconds(5);
        Aud.Play();
        Panel.SetActive(true);
        Time.timeScale = 0;
        while(time <= 1.5f)
        {
            time += Time.unscaledDeltaTime;
            yield return null;
        }
        time = 0;

        if (check)
        StartCoroutine(timestop());

        Panel.SetActive(false);
        Time.timeScale = 1;

        yield return null;
    }
}
