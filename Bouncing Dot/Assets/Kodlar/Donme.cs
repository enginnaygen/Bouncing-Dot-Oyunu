using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donme : MonoBehaviour
{
    public float beklemesüresi;
    

    void Update()
    {
        StartCoroutine(AltýgenDonusu());

    }

        

        IEnumerator AltýgenDonusu()
        {
            Vector2 mousePozisyonu = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x,0));

            if (Input.GetMouseButtonDown(0) && mousePozisyonu.x>0)
            {
                transform.Rotate(0, 0, -20);
                yield return new WaitForSeconds(0.1f);
                transform.Rotate(0, 0, -20);
                yield return new WaitForSeconds(0.1f);
                transform.Rotate(0, 0, -20);
        }
        else if (Input.GetMouseButtonDown(0) && mousePozisyonu.x < 0)
        {
                transform.Rotate(0, 0,20);
                yield return new WaitForSeconds(0.1f);
                transform.Rotate(0, 0, 20);
                yield return new WaitForSeconds(0.1f);
                transform.Rotate(0, 0, 20);
        }
        }
        
    }
