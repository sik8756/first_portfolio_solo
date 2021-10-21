using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatsonMove : MonoBehaviour
{
    SpriteRenderer SR;
    [SerializeField]
    Transform StartPos;
    [SerializeField]
    Transform EndPos;
    [SerializeField]
    float speed;
    [SerializeField]
    int Cound;

    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    public IEnumerator Pattern()
    {
        
        for (int repeat = 2; repeat <= Cound+1; repeat++)
        {
            SR.flipX = false;
            while (gameObject.transform.localPosition.x >= EndPos.transform.localPosition.x)
            {
                transform.Translate(new Vector2(-speed * ((float)repeat / 2) * Time.deltaTime, 0));

                yield return null;
            }

            SR.flipX = true;
            while (gameObject.transform.localPosition.x <= StartPos.transform.localPosition.x)
            {
                transform.Translate(new Vector2(speed * ((float)repeat / 2) * Time.deltaTime, 0));
                yield return null;
            }
        }

        
        yield return null;
    }
}
