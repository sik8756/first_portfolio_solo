using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbit : MonoBehaviour
{
    [SerializeField]
    GameObject Rabbit;



    public IEnumerator StartPattern()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(Rabbit, transform.position, Quaternion.identity);        
        StartCoroutine(StartPattern());
        yield return null;
    }

}
