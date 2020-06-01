using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject som;
    public GameObject musica;
    public Vector3 LastCheckPointPos;
    public Vector2 cameraChangeMax;
    public Vector2 cameraChangeMin;
    public Vector3 playerChange;
    private static GameMaster instance;
    public float VolumeMax = 1f;
    public float VolumeMin = 0f;
    public float Volume = 1f;
    public float SoundVol = 1f;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(this);
        }
       
    }
    void Start()
    {
        
    }
    void Update()
    {
         if(Volume > VolumeMax)
        {
            Volume = 1f;
        }
         if(Volume < VolumeMin)
        {
            Volume = 0f;
        }
    }
}
