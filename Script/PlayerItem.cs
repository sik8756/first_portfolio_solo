using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    bool GodItem;
    bool timecheck;
    float time;
    SpriteRenderer SR;
    Rigidbody2D RB;
    [SerializeField]
    AudioClip AC;
    AudioSource Aud;
    void Start()
    {
        Aud = GetComponent<AudioSource>();
        RB = GetComponent<Rigidbody2D>();
        SR = GetComponent<SpriteRenderer>();
        if(ShopManager.God == true)
        {
            ShopManager.God = false;
            GodItem = true;
        }
    }

    private void Update()
    {
        if (GodItem && Input.GetKeyDown(KeyCode.Alpha1))
        {
            GodItem = false;
            RB.bodyType = RigidbodyType2D.Kinematic;
            SR.color = new Color(1, 1, 0, 1);
            Aud.clip = AC;
            Aud.volume = 0.7f;
            Aud.Play();
            PlayerMove.move = true;
            Player.God = true;
            timecheck = true;
            time = 0;
        }

        if(timecheck)
        {
            time += Time.deltaTime;
            if(time >= 3)
            {
                PlayerMove.move = false;
                Player.God = false;
                timecheck = false;
                SR.color = new Color(1, 0, 1, 1);
                RB.bodyType = RigidbodyType2D.Dynamic;
                
            }
        }
    }
}
