using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigrabbit : MonoBehaviour
{
    [SerializeField]
    GameObject Denger;
    [SerializeField]
    Transform Up;
    [SerializeField]
    Transform Down;
    [SerializeField]
    float speed;



    public IEnumerator Pattern()
    {
        yield return new WaitForSeconds(3);
        Denger.SetActive(true);
        yield return new WaitForSeconds(1);
        Denger.SetActive(false);
        
        while(gameObject.transform.position.y <= Up.transform.position.y)
        {
            transform.Translate(new Vector2(0, speed * Time.deltaTime));
            yield return null;
        }

        while(gameObject.transform.position.y >= Down.transform.position.y)
        {
            transform.Translate(new Vector2(0, -speed * Time.deltaTime));
            yield return null;
        }


        yield return null;
    }
}
