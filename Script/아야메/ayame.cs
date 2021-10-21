using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayame : MonoBehaviour
{
    AudioSource Aud;
    [SerializeField]
    Transform Pos;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject Wall;
    [SerializeField]
    GameObject Ground;
    [SerializeField]
    GameObject BackGround;
    [SerializeField]
    GameObject hi;
    [SerializeField]
    List<GameObject> Danger = new List<GameObject>();
    [SerializeField]
    List<GameObject> Hit = new List<GameObject>();
    [SerializeField]
    Transform Left;
    [SerializeField]
    Transform Right;
    int ran;
    int ranwall, ranwall2;
    private void Start()
    {
        Aud = GetComponent<AudioSource>();    
    }



    public IEnumerator Pattern()
    {
        Aud.Play();
        yield return new WaitForSeconds(3.5f);
        Wall.SetActive(true);
        Ground.SetActive(false);
        BackGround.SetActive(false);
        Player.transform.position = Pos.transform.position;

        StartCoroutine(random());
        Danger[ran].SetActive(true);
        yield return new WaitForSeconds(3.5f);
        StartCoroutine(play());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(play2());
        yield return new WaitForSeconds(3.5f);
        StartCoroutine(play());
        yield return new WaitForSeconds(0.5f);
        Hit[ran].SetActive(false);      
        yield return new WaitForSeconds(3.5f);
        yield return StartCoroutine(hihi());
        StartCoroutine(random());
        Danger[ran].SetActive(true);
        yield return new WaitForSeconds(3.5f);
        StartCoroutine(play());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(play2());
        yield return new WaitForSeconds(3.5f);
        StartCoroutine(play());
        yield return new WaitForSeconds(0.5f);
        Hit[ran].SetActive(false);
        yield return new WaitForSeconds(15);
        Wall.SetActive(false);
        Ground.SetActive(true);
        BackGround.SetActive(true);
        yield return null;
    }

    IEnumerator random()
    {
        ran = Random.Range(0, 5);
        yield return null;
    }

    IEnumerator hihi()
    {
        yield return new WaitForSeconds(0.5f);

        for(int Repetition = 0; Repetition < 15; Repetition++)
        {
            Vector2 Pos = new Vector2(Random.Range(Left.transform.position.x, Right.transform.position.x), Left.transform.position.y);
            Danger[5].SetActive(true);
            Danger[5].transform.position = new Vector2(Pos.x, Pos.y - Left.transform.position.y);
            yield return new WaitForSeconds(0.2f);
            Danger[5].SetActive(false);
            Instantiate(hi, Pos, Quaternion.identity);
            yield return null;
        }

        yield return null;
    }

    IEnumerator reversalreversal()
    {
        Player.transform.position = new Vector2(-1 * Player.transform.position.x, Player.transform.position.y);


        yield return null;
    }

    IEnumerator play()
    {
        StartCoroutine(reversalreversal());
        Danger[ran].SetActive(false);
        Hit[ran].SetActive(true);

        yield return null;
    }

    IEnumerator play2()
    {
        Hit[ran].SetActive(false);
        StartCoroutine(random());
        Danger[ran].SetActive(true);
        yield return null;
    }
}
