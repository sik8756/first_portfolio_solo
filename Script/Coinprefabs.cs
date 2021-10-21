using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinprefabs : MonoBehaviour
{
    void Start()
    {
        Invoke("Death", 15);
    }

    void Death()
    {
        Destroy(gameObject);
    }

}
