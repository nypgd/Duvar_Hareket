using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunBaslangic : MonoBehaviour
{
   
    
    public void OyunBaslama()
    {
        SceneManager.LoadScene("duvarHareket");
    }

    public void Cikis()
    {
        Application.Quit();
    }
}
