using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayameA : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    float time;
    [SerializeField]
    float speed;
    Vector2 PlayerPos;
    Vector2 PlayerPosnormal;
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 0.25f)
        {
            time = 0;
            PlayerPos = Player.transform.position - gameObject.transform.position;
            PlayerPosnormal = PlayerPos.normalized;
        }

        transform.Translate(PlayerPosnormal * speed * Time.deltaTime);
    }
}
