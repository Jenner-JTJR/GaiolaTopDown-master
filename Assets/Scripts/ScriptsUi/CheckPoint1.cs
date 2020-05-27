 
using System.Collections.Specialized;
using System.Media;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint1 : MonoBehaviour
{
    private GameMaster gm;
    public Transform Player;
    private CameraMove cam;
    public Vector2 cameraChangeMax;
    public Vector2 cameraChangeMin;
    public Vector3 playerChange;


    void Start()
    {
        cam = Camera.main.GetComponent<CameraMove>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        

    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gm.LastCheckPointPos = transform.position;
            gm.cameraChangeMin = cameraChangeMin;
            gm.cameraChangeMax = cameraChangeMax;
            gm.playerChange = playerChange;
        }

    }
   
    
        
}
