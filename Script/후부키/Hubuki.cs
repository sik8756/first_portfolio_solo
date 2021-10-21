using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hubuki : MonoBehaviour
{
    [SerializeField]
    GameObject where;




    public IEnumerator Pattern()
    {
        yield return StartCoroutine(where.GetComponent<where>().Pattern());


        yield return null;
    }
}
