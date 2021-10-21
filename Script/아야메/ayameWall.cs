using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayameWall : MonoBehaviour
{
    SpriteRenderer SR;
    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
    }




    public IEnumerator Red()
    {
        SR.color = new Color(1, 0, 0, 1);
        yield return null;
    }

    public IEnumerator reset()
    {
        SR.color = new Color(1, 1, 1, 1);
        yield return null;
    }
}
