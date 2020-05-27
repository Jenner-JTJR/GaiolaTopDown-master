using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject menu;

   public void OnClick()
    {
        LeanTween.scale(menu, new Vector3(0, 0, 0), 0f).setOnComplete(show);

    }
    void show()
    {
        menu.SetActive(true);
        LeanTween.scale(menu, new Vector3(0, 0, 0), 0f).setOnComplete(Click);

    }
    public void Click()
    {
        LeanTween.scale(menu, new Vector3(1f, 1f, 1f), 0.5f);
    }
}
