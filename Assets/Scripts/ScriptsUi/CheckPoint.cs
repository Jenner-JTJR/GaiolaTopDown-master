
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private GameMaster gm;
    public Transform Player;
    private CameraMove cam;
    public Vector2 cameraChangeMax;
    public Vector2 cameraChangeMin;
    public Vector3 playerChange;
    public Vector3 LastCheckPointPos;


    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gm.LastCheckPointPos = LastCheckPointPos;
            gm.cameraChangeMin = cameraChangeMin;
            gm.cameraChangeMax = cameraChangeMax;
            gm.playerChange = playerChange;
            
        }

    }
}