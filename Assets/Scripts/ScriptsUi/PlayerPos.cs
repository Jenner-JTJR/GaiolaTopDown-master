using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
    private CameraMove cam;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        cam = Camera.main.GetComponent<CameraMove>();
        transform.position = gm.LastCheckPointPos;
        cam.minPosition = gm.cameraChangeMin;
        cam.maxPosition = gm.cameraChangeMax;
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
