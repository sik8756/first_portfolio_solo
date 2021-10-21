using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option : MonoBehaviour
{
    [SerializeField]
    GameObject Soundbox;



    public void sound()
    {
        Soundbox.SetActive(true);
    }

    public void Quit()
    {
        Soundbox.SetActive(false);
    }
}
