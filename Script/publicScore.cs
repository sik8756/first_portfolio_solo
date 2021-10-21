using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class publicScore : MonoBehaviour
{

    Text text;

    void Start()
    {
        PlayerPrefs.SetInt("DataCoin", ScoreManager.Coin);

        text = GetComponent<Text>();

        text.text = ScoreManager.score2.ToString();
    }

}
