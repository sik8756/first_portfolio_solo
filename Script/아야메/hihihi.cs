using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hihihi : MonoBehaviour
{
    [SerializeField]
    float speed;

    private void Start()
    {
        Invoke("Death", 5);    
    }

    void Update()
    {
        transform.Translate(new Vector2(0, -speed *Time.deltaTime));
    }

    void Death()
    {

    }
}
