using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Delete", 1.5f);
    }


    void Delete()
    {
        Destroy(gameObject);
    }
}
