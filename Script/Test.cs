using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    AudioSource aud;
    [SerializeField]
    float speed;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }
    private void Start()
    {
        aud.Play();
        int Ran = Random.Range(-95, -150);
        transform.rotation = Quaternion.Euler(0, 0, Ran);

        Destroy(gameObject, 2.5f);
    }

    void Update()
    {
        transform.Translate(new Vector2(0, speed * Time.deltaTime));
    }
}
