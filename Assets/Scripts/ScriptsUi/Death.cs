using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject MorteUi;
    public bool Dead;
    void Start()
    {
        Dead = false;

    }
    private void OnTriggerEnter2D(Collider2D collision)
        
    {

        
        if (collision.CompareTag("Player"))
        {
            LeanTween.scale(MorteUi, new Vector3(0, 0, 0), 0f).setOnComplete(Active);
        }
    }
    void Active()
    {
        MorteUi.SetActive(true);
        LeanTween.scale(MorteUi, new Vector3(1, 1, 1), 0.4f);
    }
    void Update()
    {
        if (Dead == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    } 
    
}
