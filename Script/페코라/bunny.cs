using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunny : MonoBehaviour
{
    [SerializeField]
    GameObject Danger;
    [SerializeField]
    Transform Left;
    [SerializeField]
    Transform Right;
    [SerializeField]
    float speed;
    bool down;
    void Start()
    {
        gameObject.transform.position = new Vector2(Random.Range(Left.transform.position.x, Right.transform.position.x),Left.transform.position.y);
        Invoke("one", 0.5f);
        Invoke("Death", 3);
    }

    void Update()
    {
        if(down)
        {
            transform.Translate(new Vector2(0, -speed * Time.deltaTime));
        }
    }

    void one()
    {
        Danger.SetActive(false);
        down = true;
    }
    void Death()
    {
        Destroy(gameObject);
    }
}
