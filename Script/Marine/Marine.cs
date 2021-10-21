using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marine : MonoBehaviour
{
    [SerializeField]
    GameObject Ahoy;


    public IEnumerator StartPattern()
    {
        yield return StartCoroutine(Ahoy.GetComponent<Ahoy>().Pattern());


        yield return null;
    }
}
