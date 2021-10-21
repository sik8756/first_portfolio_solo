using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    Text text;
    [SerializeField]
    float getscore;
    void Start()
    {   
        text = GetComponent<Text>();
        if(ShopManager.DoubleScore == true)
        {
            getscore += 5;
            ShopManager.DoubleScore = false;
        }
    }

    
    void Update()
    {
        ScoreManager.score += getscore * Time.deltaTime;

        ScoreManager.score2 = (int)ScoreManager.score;

        text.text = ScoreManager.score2.ToString();
       
    }
}
