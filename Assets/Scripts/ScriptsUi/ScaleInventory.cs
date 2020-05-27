using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class ScaleInventory : MonoBehaviour
{
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject BG;
    public GameObject PauseIcon;
    public bool IsOpen = false;

   public void Appear()
    {
        if (IsOpen == false)
        {
            LeanTween.scale(Slot1, new Vector3(0, 0, 0), 0f);
            LeanTween.scale(Slot2, new Vector3(0, 0, 0), 0f);
            LeanTween.scale(Slot3, new Vector3(0, 0, 0), 0f);
            LeanTween.scale(Slot4, new Vector3(0, 0, 0), 0f);
            LeanTween.scale(BG, new Vector3(0, 0, 0), 0f).setOnComplete(IsInventory);
        }
        else
        {
            LeanTween.scale(Slot4, new Vector3(0, 0, 0), 0.1f);
            LeanTween.scale(Slot3, new Vector3(0, 0, 0), 0.2f);
            LeanTween.scale(Slot2, new Vector3(0, 0, 0), 0.3f);
            LeanTween.scale(Slot1, new Vector3(0, 0, 0), 0.4f);
            LeanTween.scale(BG, new Vector3(0, 0, 0), 0.6f).setOnComplete(Close);
        }
       
        
    }
    void IsInventory()
    {
        if (IsOpen == false)
        {
            Slot1.SetActive(true);
            Slot2.SetActive(true);
            Slot3.SetActive(true);
            Slot4.SetActive(true);
            BG.SetActive(true);
            LeanTween.scale(BG, new Vector3(1, 1, 1), 0.2f);
            LeanTween.scale(Slot1, new Vector3(1, 1, 1), 0.3f);
            LeanTween.scale(Slot2, new Vector3(1, 1, 1), 0.4f);
            LeanTween.scale(Slot3, new Vector3(1, 1, 1), 0.5f);
            LeanTween.scale(Slot4, new Vector3(1, 1, 1), 0.6f);
            IsOpen = true;
        }
    }
    void Close()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(false);
        BG.SetActive(false);
        IsOpen = false;
    }
}
