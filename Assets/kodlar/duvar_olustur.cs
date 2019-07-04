using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class duvar_olustur : MonoBehaviour
{
    public GameObject duvar;  
    float zaman;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        if (zaman >Random.Range(0.6f, 10))
        {
            Instantiate(duvar, duvar.transform.position, Quaternion.identity);//duvar oluşturma
            zaman = 0;
        }        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "duvar")
        {
            Destroy(other.gameObject);

        }
    }
}
