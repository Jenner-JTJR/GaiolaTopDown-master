using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class ScaleTwen : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update
 public void OnClose() //Fecha o Menu
    {
        LeanTween.scale(menu, new Vector3(0, 0, 0), 0.3f).setOnComplete(hide);
    }
    void hide()
    {
        menu.SetActive(false);
    }
}
