using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerchase : MonoBehaviour
{
    [SerializeField]
    Transform player;

    public bool check;

    IEnumerator chase()
    {
        while(!check)
        transform.position = new Vector2(player.transform.position.x, 0);

        yield return null;
    }
}
