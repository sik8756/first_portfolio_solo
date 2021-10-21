using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    [SerializeField]
    List<GameObject> go = new List<GameObject>();
    [SerializeField]
    GameObject Item;
    [SerializeField]
    GameObject Coin;
    AudioSource Aud;
    int Itemrandom;
    int Coinrandom;
    int random;
    public int Count;

    public bool GameStart;
    bool get;

    float time;
    float stoptime;
    [SerializeField]
    float Hpbarpercentage;
    [SerializeField]
    Transform TopLeft;
    [SerializeField]
    Transform BatteumRight;
    [SerializeField]
    Text bonus;
    [SerializeField]
    Text bonusScore;
    Vector2 ItemspawnPos;
    Vector2 CoinspawnPos;
    List <bool> check = new List<bool>();

    private void Awake()
    {
        Aud = GetComponent<AudioSource>();
        for(int i = 0; i<go.Count; i ++)
        {
            check.Add(true);
        }
    }

    private void Start()
    {
        Aud.volume = SoundManager.BackGornudSound;
    }

    private void Update()
    {

        if (!GameStart)
        {
            random = Random.Range(0, go.Count);

            if (random == 0 && check[0])
            {
                GameStart = true;
                check[0] = false;
                StartCoroutine(StartPattern());
            }
            else if(random == 0 && !check[0])
            GameStart = false;

            if ( random == 1 && check[1])
            {
                GameStart = true;
                check[1] = false;
                StartCoroutine(StartSecondPattern());
            }
            else if (random == 1 && !check[1])
            GameStart = false;

            if (random == 2 && check[2])
            {
                GameStart = true;
                check[2] = false;
                StartCoroutine(StartthirdPattern());
            }
            else if (random == 2 && !check[2])
            GameStart = false;

            if (random == 3 && check[3])
            {
                GameStart = true;
                check[3] = false;
                StartCoroutine(StartfourthPattern());
            }
            else if (random == 3 && !check[3])
                GameStart = false;

            if (random == 4 && check[4])
            {
                GameStart = true;
                check[4] = false;
                StartCoroutine(StartFivePattern());
            }
            else if (random == 4 && !check[4])
                GameStart = false;

            if (random == 5 && check[5])
            {
                GameStart = true;
                check[5] = false;
                StartCoroutine(STartsixthPattern());
            }
            else if (random == 5 && !check[5])
                GameStart = false;

            if (random == 6 && check[6])
            {
                GameStart = true;
                check[6] = false;
                StartCoroutine(StartSevenPattern());
            }
            else if (random == 6 && !check[6])
                GameStart = false;

            //if (random == 7 && check[7])
            //{
            //    GameStart = true;
            //    check[7] = false;
            //    StartCoroutine(StarteighthPattern());
            //}
            //else if (random == 7 && !check[7])
            //    GameStart = false;

            if (!check[0] && !check[1] && !check[2] && !check[3] && !check[4] && !check[5] && !check[6])
            {
                for(int reset = 0; reset < check.Count; reset++)
                {
                    check[reset] = true;
                }
            }
        }
        if (get)
        {
            time += Time.deltaTime / 1.5f;
            stoptime += Time.deltaTime;
            bonusScore.text = (200 + ((Count-1) * 50)).ToString();
            bonus.color = new Color(1, 0, 1, Mathf.Lerp(1, 0, time));
            bonusScore.color = new Color(1, 0, 1, Mathf.Lerp(1, 0, time));
            
        }

        if (stoptime >= 1.5f)
        {
            stoptime = 0;
            get = false;
            time = 0;
            bonus.color = new Color(1, 0, 1, 0);
            bonusScore.color = new Color(1, 0, 1, 0);
        }
    }

    IEnumerator StartPattern()
    {

        Player.hitBouns = false;
        StartCoroutine(numberchange());
        StartCoroutine(produce());

        go[0].SetActive(true);
        yield return null;
        yield return StartCoroutine(go[0].GetComponent<Gura>().firstPattern());
        if(!Player.hitBouns)
        {
            ScoreManager.score += (200 + (Count * 50));
            get = true;
            Count++;
        }


        go[0].SetActive(false);
        GameStart = false;
        yield return null; 
    }

    IEnumerator StartSecondPattern()
    {
        Player.hitBouns = false;
        StartCoroutine(numberchange());
        StartCoroutine(produce());
        go[1].SetActive(true);
        yield return null;
        yield return StartCoroutine(go[1].GetComponent<Ollie>().OllieStartCoroutine());
        if (!Player.hitBouns)
        {
            ScoreManager.score += (200 + (Count * 50));
            get = true;
            Count++;
        }

        go[1].SetActive(false);
        GameStart = false;       
        yield return null;
    }

    IEnumerator StartthirdPattern()
    {
        Player.hitBouns = false;
        StartCoroutine(numberchange());
        StartCoroutine(produce());
        go[2].SetActive(true);
        yield return null;
        yield return StartCoroutine(go[2].GetComponent<Watson>().StartfirstCoroutine());
        if (!Player.hitBouns)
        {
            ScoreManager.score += (200 + (Count * 50));
            get = true;
            Count++;
        }

        go[2].SetActive(false);
        GameStart = false;
        yield return null;
    }

    IEnumerator StartfourthPattern()
    {
        Aud.volume = 0;
        Player.hitBouns = false;
        StartCoroutine(numberchange());
        StartCoroutine(produce());
        go[3].SetActive(true);
        yield return null;
        yield return StartCoroutine(go[3].GetComponent<Lucia>().StartPattern());
        if (!Player.hitBouns)
        {
            ScoreManager.score += (200 + (Count * 50));
            get = true;
            Count++;
        }

        go[3].SetActive(false);
        GameStart = false;
        Aud.volume = 0.15f;
        yield return null;
    }

    IEnumerator StartFivePattern()
    {
        Player.hitBouns = false;
        StartCoroutine(numberchange());
        StartCoroutine(produce());
        go[4].SetActive(true);
        yield return null;
        yield return new WaitForSeconds(1.5f);
        yield return StartCoroutine(go[4].GetComponent<Peko>().StartPattern());
        if (!Player.hitBouns)
        {
            ScoreManager.score += (200 + (Count * 50));
            get = true;
            Count++;
        }

        go[4].SetActive(false);
        GameStart = false;
        yield return null;
    }

    IEnumerator STartsixthPattern()
    {
        Player.hitBouns = false;
        StartCoroutine(numberchange());
        StartCoroutine(produce());
        go[5].SetActive(true);
        yield return null;
        yield return new WaitForSeconds(1.5f);
        yield return StartCoroutine(go[5].GetComponent<Marine>().StartPattern());
        if (!Player.hitBouns)
        {
            ScoreManager.score += (200 + (Count * 50));
            get = true;
            Count++;
        }

        go[5].SetActive(false);
        GameStart = false;
        yield return null;
    }

    IEnumerator StartSevenPattern()
    {
        Player.hitBouns = false;
        StartCoroutine(numberchange());
        StartCoroutine(produce());
        yield return null;
        yield return new WaitForSeconds(1.5f);
        go[6].SetActive(true);
        yield return null;
        yield return StartCoroutine(go[6].GetComponent<Hubuki>().Pattern());
        if (!Player.hitBouns)
        {
            ScoreManager.score += (200 + (Count * 50));
            get = true;
            Count++;
        }

        go[6].SetActive(false);
        GameStart = false;
        yield return null;
    }

    //IEnumerator StarteighthPattern()
    //{
    //    Player.hitBouns = false;
    //    Itemrandom = Random.Range(1, 101);
    //    ItemspawnPos = new Vector2(Random.Range(TopLeft.transform.localPosition.x, BatteumRight.transform.localPosition.x)
    //                     , Random.Range(BatteumRight.transform.localPosition.y, TopLeft.transform.localPosition.y));
    //    if (Itemrandom < Hpbarpercentage)
    //    {
    //        Instantiate(Item, ItemspawnPos, Quaternion.identity);
    //        Hpbarpercentage--;
    //    }
    //    yield return null;
    //    yield return new WaitForSeconds(1.5f);
    //    go[7].SetActive(true);
    //    yield return null;
    //    yield return StartCoroutine(go[7].GetComponent<Korone>().Pattern());
    //    if (!Player.hitBouns)
    //    {
    //        ScoreManager.score += (200 + (Count * 50));
    //        get = true;
    //        Count++;
    //    }

    //    go[7].SetActive(false);
    //    GameStart = false;
    //    yield return null;
    //}

    IEnumerator numberchange()
    {
        Itemrandom = Random.Range(1, 101);
        Coinrandom = Random.Range(1, 101);
        ItemspawnPos = new Vector2(Random.Range(TopLeft.transform.localPosition.x, BatteumRight.transform.localPosition.x)
                         , Random.Range(BatteumRight.transform.localPosition.y, TopLeft.transform.localPosition.y));
        CoinspawnPos = new Vector2(Random.Range(TopLeft.transform.localPosition.x, BatteumRight.transform.localPosition.x)
                         , Random.Range(BatteumRight.transform.localPosition.y, TopLeft.transform.localPosition.y));

        yield return null;
    }
    IEnumerator produce()
    {
        if (Itemrandom < Hpbarpercentage)
        {
            Instantiate(Item, ItemspawnPos, Quaternion.identity);
            Hpbarpercentage--;
        }
        if (Coinrandom < 50)
            Instantiate(Coin, CoinspawnPos, Quaternion.identity);

        yield return null;
    }
}
