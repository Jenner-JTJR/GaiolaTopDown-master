using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeS : MonoBehaviour
{
    public Slider slider;
    private GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        slider.value = gm.SoundVol;
    }

    // Update is called once per frame
    void Update()
    {
        gm.SoundVol = slider.value;
    }
}
