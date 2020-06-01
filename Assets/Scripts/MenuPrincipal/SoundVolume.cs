using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SoundVolume : MonoBehaviour
{
    public AudioSource Som;
    private GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
     
    }

    // Update is called once per frame
    void Update()
    {
        Som.volume = gm.SoundVol;
    }
}
