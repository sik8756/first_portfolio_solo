using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    [SerializeField]
    Text text;
    private void Start()
    {
       ScoreManager.Coin = PlayerPrefs.GetInt("DataCoin");
    }

    void Update()
    {
        text.text = ScoreManager.Coin.ToString();
    }
}
