using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{

    public static bool God;
    public static bool DoubleScore;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


}
