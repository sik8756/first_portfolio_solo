using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrot : MonoBehaviour
{
    [SerializeField]
    GameObject Denger;
    [SerializeField]
    Transform up;
    [SerializeField]
    Transform down;

    [SerializeField]
    float speed;
    bool go;
    void Start()
    {
        int ran;
        ran = Random.Range(0, 2);
        if(ran == 0)
        {
            gameObject.transform.position = new Vector2(up.transform.position.x, up.transform.position.y);
        }
        if(ran == 1)
        {
            gameObject.transform.position = new Vector2(down.transform.position.x, down.transform.position.y);
        }
        Invoke("Death", 3);
        Invoke("on", 0.7f);
    }

    
    void Update()
    {
        if(go)
        transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
    }

    void Death()
    {
        Destroy(gameObject);
    }
    void on()
    {
        Denger.SetActive(false);
        go = true;
    }
}
