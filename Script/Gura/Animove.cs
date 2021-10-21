using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animove : MonoBehaviour
{
    [SerializeField]
    List<GameObject> English = new List<GameObject>();

    Vector2 origin;


    private void Start()
    {
        origin = English[0].transform.localPosition;
    }

    public IEnumerator move()
    {
        for(int Engmove = 0; Engmove < English.Count; Engmove++)
        {
            English[Engmove].transform.localPosition = new Vector2(English[Engmove].transform.localPosition.x,
                English[Engmove].transform.localPosition.y + 0.5f);

            yield return new WaitForSeconds(0.3f);

            English[Engmove].transform.localPosition = new Vector2(English[Engmove].transform.localPosition.x,
               English[Engmove].transform.localPosition.y - 0.5f);
        }
        StartCoroutine(move());

        yield return null;
    }


    public IEnumerator reset()
    {
        English[0].transform.localPosition = new Vector2(origin.x,origin.y);



        yield return null;
    }
}
