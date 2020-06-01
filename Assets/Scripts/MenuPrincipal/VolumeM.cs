using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeM : MonoBehaviour
{
    public Slider slider;
    private GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        slider.value = gm.Volume;

    }

    // Update is called once per frame
    void Update()
    {
        gm.Volume = slider.value;
    }
}
