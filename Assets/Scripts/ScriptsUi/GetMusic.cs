using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMusic : MonoBehaviour
{
    public GameObject Music;

    // Update is called once per frame
    public void Musica()
    {
        Music = GameObject.FindWithTag("Music");
    }
}
