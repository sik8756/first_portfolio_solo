using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watson : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Waston = new List<GameObject>();
    AudioSource Aud;

    private void Start()
    {
        Aud = GetComponent<AudioSource>();
    }

    public IEnumerator StartfirstCoroutine()
    {
        Aud.Play();
        yield return new WaitForSeconds(2f);
        Waston[1].GetComponent<FuckYou>().check = true;
        Waston[2].GetComponent<TimeStop>().check = true;
        StartCoroutine(Waston[1].GetComponent<FuckYou>().Up());
        StartCoroutine(Waston[2].GetComponent<TimeStop>().timestop());
        yield return StartCoroutine(Waston[0].GetComponent<WatsonMove>().Pattern());
        Waston[1].GetComponent<FuckYou>().check = false;
        Waston[2].GetComponent<TimeStop>().check = false;
        yield return StartCoroutine(Waston[1].GetComponent<FuckYou>().End());
        Waston[2].GetComponent<TimeStop>().StopAllCoroutines();

        Debug.Log("끝남");
        
       yield return null;
    }

}
