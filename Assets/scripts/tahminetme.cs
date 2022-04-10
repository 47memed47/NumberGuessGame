using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class tahminetme : MonoBehaviour
{ 
    public int tahmin;
    public int kucuksayi=0;
    public int buyuksayi=100;
    public Text yazi;

    public void hesapla()
    {
        tahmin = UnityEngine.Random.Range(kucuksayi, buyuksayi);
        yazi.text = tahmin.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        hesapla();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("cikisyap");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            kucuksayi = tahmin;
            hesapla();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            buyuksayi = tahmin;
            hesapla();
        }
    }
}
