using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turtle : MonoBehaviour
{
    SpriteRenderer SR;

    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }
    public IEnumerator Pattern(Transform Start, Transform End, float time)
    {
        SR.flipX = false;
        float timer = 0;
        Vector2 move = Start.transform.position;
        gameObject.transform.position = Start.transform.position;

        while(transform.position.x <= End.transform.position.x)
        {
            timer += Time.deltaTime;
            move.x = Mathf.Lerp(Start.transform.position.x, End.transform.position.x, timer / time);

            transform.position = move;
            yield return null;
        }

        yield return null;
    }

    public IEnumerator reversePattern(Transform Start, Transform End, float time)
    {
        SR.flipX = true;
            float timer = 0;
            Vector2 move = Start.transform.position;

            while (transform.position.x >= Start.transform.position.x)
            {
                timer += Time.deltaTime;
                move.x = Mathf.Lerp(End.transform.position.x, Start.transform.position.x, timer / time);

                transform.position = move;
                yield return null;
            }

            yield return null;
    }
}
