using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static int Count;
    public static float BackGornudSound = 0.5f;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
