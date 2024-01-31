using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Top : MonoBehaviour
{
    SpriteRenderer srTop;
    Rigidbody2D rbTop;
    public float TopHýzý;
    public Color Mavi, Pembe, Sarý, Turuncu, Kýrmýzý, Yesil;
    public int skor,rekor;
    public Text SkorYazýsý, RekorYazýsý;
 
   

    void Start()
    {
        srTop = GetComponent<SpriteRenderer>();
        rbTop = GetComponent<Rigidbody2D>();

        if (PlayerPrefs.HasKey("yuksekskor"))
        {
            rekor = PlayerPrefs.GetInt("yuksekskor");
            RekorYazýsý.text = "Rekor: " + rekor;
        }
        else
        {
            rekor = 0;
        }
        


    }



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "kenar")
        {
            rbTop.velocity = new Vector2(0, TopHýzý);

            if (srTop.color == collision.gameObject.GetComponent<SpriteRenderer>().color)
            {
                skor += 1;
                SkorYazýsý.text = "Skor: " + skor;
               

                if(skor>rekor)
                {
                    rekor = skor;
                    RekorYazýsý.text = "Rekor: " + rekor;
                    PlayerPrefs.SetInt("yuksekskor", rekor);
                }

            }

            else if (srTop.color != collision.gameObject.GetComponent<SpriteRenderer>().color)
            {
                SceneManager.LoadScene(0);
            }   
        }
        if (collision.gameObject.tag == "zýplatýcý")
        {
            rbTop.velocity = new Vector2(0, 4);

            
        }
    }



        /* if (collision.gameObject.tag == "mavi" && srTop.color == Mavi)
        {
            rbTop.velocity = new Vector2(0, TopHýzý);
            skor += 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "yesil" && srTop.color == Yesil)
        {
            rbTop.velocity = new Vector2(0, TopHýzý);
            skor += 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "pembe" && srTop.color == Pembe)
        {
            rbTop.velocity = new Vector2(0, TopHýzý);
            skor += 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "kýrmýzý" && srTop.color == Kýrmýzý)
        {
            rbTop.velocity = new Vector2(0, TopHýzý);
            skor += 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "turuncu" && srTop.color == Turuncu)
        {
            rbTop.velocity = new Vector2(0, TopHýzý);
            skor += 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "sarý" && srTop.color == Sarý)
        {
            rbTop.velocity = new Vector2(0, TopHýzý);
            skor += 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "sarý" && srTop.color != Sarý)
        {
            skor -= 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "mavi" && srTop.color != Mavi)
        {
            skor -= 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "kýrmýzý" && srTop.color != Kýrmýzý)
        {
            skor -= 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "turuncu" && srTop.color != Turuncu)
        {
            skor -= 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "yesil" && srTop.color != Yesil)
        {
            skor -= 5;
            Debug.Log(skor);
        }
        if (collision.gameObject.tag == "pembe" && srTop.color != Pembe)
        {
            skor -= 5;
            Debug.Log(skor);
        }*/
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "renkverici")
        {
            RenkVerme();
        }
    }

    public void RenkVerme()
    {
        int renkler = Random.Range(1, 7);

        switch(renkler)
        {
            case 1:
                srTop.color = Mavi;
                break;
            case 2:
                srTop.color = Sarý;
                break;
            case 3:
                srTop.color = Yesil;
                break;
            case 4:
                srTop.color = Kýrmýzý;
                break;
            case 5:
                srTop.color = Pembe;
                break;
            case 6:
                srTop.color = Turuncu;
                break;
        }
    }
}
