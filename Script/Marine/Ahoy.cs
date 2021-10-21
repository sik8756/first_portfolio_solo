using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ahoy : MonoBehaviour
{
    [SerializeField]
    GameObject Marine;
    [SerializeField]
    GameObject Danger;
    [SerializeField]
    Transform Left;
    [SerializeField]
    Transform Right;

    public IEnumerator Pattern()
    {
        for (int repeat = 0; repeat < 10; repeat++)
        {
            Vector2 make;

            make = new Vector2(Random.Range(Left.transform.localPosition.x, Right.transform.localPosition.x), Left.transform.localPosition.y);
            Danger.transform.position = make;
            Danger.SetActive(true);
            yield return new WaitForSeconds(0.85f);
            Danger.SetActive(false);
            Instantiate(Marine, make, Quaternion.identity);
            yield return null;
        }
        yield return new WaitForSeconds(1.5f);

        yield return null;
    }
}
