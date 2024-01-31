using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yönetici : MonoBehaviour
{
    public Text baslamaYazısı;
    public GameObject altıgen,top;
    public Transform topPozisyonu;
    public bool basla;
    void Start()
    {
        altıgen.GetComponent<Donme>().enabled = false;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)&& basla == false)
        {
            topPozisyonu.position = new Vector2(0, 0.5f);
            altıgen.GetComponent<Donme>().enabled = true;
            top.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            //rbTop.velocity = new Vector2(0, 0);
            baslamaYazısı.text = "";
            basla = true;

        }
       
    }
}
