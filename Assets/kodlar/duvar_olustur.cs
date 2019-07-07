using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class duvar_olustur : MonoBehaviour
{
    public GameObject duvar;
    public GameObject arkaPlan;
    public SpriteRenderer gameOverarkaPlan;
    public Button oyunBittiButon;
    public Text oyunBitti;
    float zaman;
    bool durum = false;
    float j = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        if (zaman > Random.Range(0.6f, 10))
        {
            Instantiate(duvar, duvar.transform.position, Quaternion.identity);//duvar oluşturma
            zaman = 0;
        }
    }
    
    void FixedUpdate()
    {
        if (durum)
        {
            j += 0.02f;
            gameOverarkaPlan.color = new Color(0, 0, 0, j);//(R,G,B,A)//A değeri alpha değeridir IMAGE nesnesinin saydamlığını 0.01 saniyede bir j değerini arttırarark sadamlığını azalıyor yani ekranı karartıyoruz.Çünkü R=0,G=0 ve B=0 siyaha karşılık geliyor.
            if (j > 1)
            {
                Time.timeScale = 0;//oyunu durdurur
                oyunBitti.gameObject.SetActive(true);
                oyunBittiButon.gameObject.SetActive(true);
            }
        }
        
    }


    private void OnTriggerEnter(Collider other)
    {
        durum = true;
        arkaPlan.SetActive(true);
        
        Destroy(other.gameObject);

    }
    public void OyunBitti()
    {
        Time.timeScale = 1;//oyunu aktif eder
        SceneManager.LoadScene("oyunBaslangic");
    }
}
