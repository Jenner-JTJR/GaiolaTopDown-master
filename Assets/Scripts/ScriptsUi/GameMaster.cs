using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public Vector3 LastCheckPointPos;
    public Vector2 cameraChangeMax;
    public Vector2 cameraChangeMin;
    public Vector3 playerChange;
    private static GameMaster instance;
    public AudioSource Musica;
    public float Volume = 1;

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
   public void Volum()
    {
        
        


    }
}
