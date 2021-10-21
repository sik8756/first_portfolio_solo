using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundSound : MonoBehaviour
{
    Slider value;

    void Start()
    {
        value = GetComponent<Slider>();        
    }

    // Update is called once per frame
    void Update()
    {
        SoundManager.BackGornudSound = value.value;
    }
}
