using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField]
    GameObject ShopPanel;
    bool check;
    [SerializeField]
    Text text;
    float time;

    void Update()
    {
        if (time <= 1.1f)
        {
            time += Time.deltaTime / 1.25f;
            text.color = new Color(1, 0, 1, Mathf.Lerp(1, 0, time));
        }
    }
    public void GodBuy()
    {
        if (ShopManager.God == true)
        {
            textappear("아이템이 있는 상태 입니다.");
            return;
        }
        else if (ShopManager.God == false && ScoreManager.Coin < 5)
        {
            textappear("돈이 부족합니다.");
            return;
        }
        else if (ShopManager.God == false && ScoreManager.Coin >= 5)
        {
            textappear("구매가 완료되었습니다.");
            ShopManager.God = true;
            ScoreManager.Coin -= 5;
        }
    }

    public void Scoredoublespeed()
    {
        if (ShopManager.DoubleScore == true)
        {
            textappear("아이템이 있는 상태 입니다.");
            return;
        }
        else if (ShopManager.DoubleScore == false && ScoreManager.Coin < 15)
        {
            textappear("돈이 부족합니다.");
            return;
        }
        else if (ShopManager.DoubleScore == false && ScoreManager.Coin >= 15)
        {
            textappear("구매가 완료되었습니다.");
            ShopManager.DoubleScore = true;
            ScoreManager.Coin -= 15;
        }
    }

    public void PanelOnOff()
    {
        check = !check;
        ShopPanel.SetActive(check);
    }


    void textappear(string Item)
    {
        time = 0;
        text.text = Item;
    }

    public void TestMoney()
    {
        ScoreManager.Coin++;
    }
}
