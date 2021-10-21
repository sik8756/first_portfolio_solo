using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Go = new List<GameObject>();
    [SerializeField]
    int hp;

    GameObject Game;

    SpriteRenderer SR;
    AudioSource Aud;

    [SerializeField]
    float GodTime;

    float time;
    float hitTime;

    public static bool God;
    bool hit;

    [SerializeField]
    Transform originPos;
    [SerializeField]
    AudioClip CoinSound;
    [SerializeField]
    AudioClip HitSound;
    [SerializeField]
    AudioClip HpSound;
    public static bool hitBouns;
    private void Awake()
    {
        Aud = GetComponent<AudioSource>();
        SR = GetComponent<SpriteRenderer>();
        Game = GameObject.Find("GameManager");
        PlayerPrefs.SetInt("DataCoin", ScoreManager.Coin);
        ScoreManager.score += 49950;
    }

    void Update()
    {
        if(hit)
        {
            hitTime += Time.deltaTime;
            God = true;
            SR.color = new Color(1, 0, 0, 1);
            time += Time.deltaTime / GodTime;
            SR.color = new Color(1, 0, Mathf.Lerp(0, 1, time), 1);
            if(hitTime >= GodTime)
            {
                hitTime = 0;
                God = false;
                hit = false;
            }
        }

        if (hp == -1)
        SceneManager.LoadScene("Gameover");

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "enemy")
        {
            if(!God)
            {
                SoundOn(HitSound,0.5f);
                hit = true;
                hitBouns = true;
                time = 0;
                Go[hp].SetActive(false);
                hp--;
                Game.GetComponent<GameManage>().Count = 0;
            }
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Item")
        {
            if (hp == 9)
            {
                SoundOn(HpSound, 1);
                Destroy(collision.gameObject);
                return;
            }

            else
            {
                SoundOn(HpSound, 1);
                Destroy(collision.gameObject);
                hp++;
                Go[hp].SetActive(true);
            }
        }
        if(collision.tag == "Coin")
        {
            SoundOn(CoinSound, 0.5f);
            ScoreManager.Coin++;
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Fild")
        {
            if (!God)
            {
                hit = true;
                hitBouns = true;
                Aud.Play();
                time = 0;
                Go[hp].SetActive(false);
                hp--;
                Game.GetComponent<GameManage>().Count = 0;
            }

            gameObject.transform.position = originPos.transform.position;
        }
    }

    void SoundOn(AudioClip Clip, float volume)
    {
        Aud.clip = Clip;
        Aud.volume = volume;
        Aud.Play();
    }
}
