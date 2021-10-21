using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWWW : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    Transform Up;
    [SerializeField]
    Transform Bot;

    void Start()
    {
        gameObject.transform.position = new Vector2(Up.transform.position.x, Random.Range(Up.transform.position.y, Bot.transform.position.y));
        Invoke("Death" ,3f);
    }

    
    void Update()
    {
        transform.Translate(new Vector2(speed * Time.deltaTime,0));
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
