using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotPeko : MonoBehaviour
{
    [SerializeField]
    GameObject carrot;


    public IEnumerator Pattern()
    {
        Instantiate(carrot, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1.25f);
        StartCoroutine(Pattern());
        yield return null;
    }
}
