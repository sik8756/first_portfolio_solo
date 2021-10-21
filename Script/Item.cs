using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void Start()
    {
        Invoke("Delete", 15);
    }

    void Delete()
    {
        Destroy(gameObject);
    }

}
