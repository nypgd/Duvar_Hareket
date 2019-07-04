using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kare_tiklama : MonoBehaviour
{
    public bool kare_tiklama_durum = false;
    private void Start()
    {
        kare_tiklama_durum = false;
    }
    private void OnMouseDown()
    {
        kare_tiklama_durum = true;
        print("kare tıklandı");
    }
}
