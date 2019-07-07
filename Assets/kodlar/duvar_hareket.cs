using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvar_hareket : MonoBehaviour
{

    Rigidbody fizik;
    float hiz = 1000;
    bool tiklama_durum = false;
    int rasgele_sag_sol;
    int x_hiz_sag, x_hiz_sol;
    int y_hiz_ust, y_hiz_alt;
    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        if (tiklama_durum)//duvara tıklanmışsa
        {

            if (rasgele_sag_sol == 0)
            {
                fizik.velocity = new Vector3(20, 0, 0) * Time.deltaTime * hiz;//sağa gidiyor
                x_hiz_sag += 20;
                if (x_hiz_sag > 2000)
                {
                    Destroy(gameObject);
                }
            }
            else if (rasgele_sag_sol == 1)
            {
                fizik.velocity = new Vector3(-20, 0, 0) * Time.deltaTime * hiz;//sola gidiyor
                x_hiz_sol -= 20;
                if (x_hiz_sol < -2000)
                {
                    Destroy(gameObject);
                }
            }
            else if (rasgele_sag_sol == 2)
            {
                fizik.velocity = new Vector3(0, 20, 0) * Time.deltaTime * hiz;//üste gidiyor
                y_hiz_ust += 20;
                if (y_hiz_ust > 1000)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                fizik.velocity = new Vector3(0, -20, 0) * Time.deltaTime * hiz;//alta gidiyor
                y_hiz_alt -= 20;
                if (y_hiz_alt < -1000)
                {
                    Destroy(gameObject);
                }

            }

        }
        else//duvara tıklanmamışsa düz gidiyor
        {
            fizik.velocity = new Vector3(0, 0, -20) * Time.deltaTime * hiz;//düz gidiyor
        }

    }


    private void OnMouseDown()
    {
        // if (GameObject.FindGameObjectWithTag("duvar").GetComponent<kare_tiklama>().kare_tiklama_durum == true)
        //  {
        Debug.Log("tıklandı");
        tiklama_durum = true;
        rasgele_sag_sol = Random.Range(0, 4);//0,1,2,3 sayıları rasgele olarak seçiliyor 
        // }

    }

}
