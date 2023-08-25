using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odev1 : MonoBehaviour
{
    public int puan = 50;
    public float yol = 3.0f;
    string girisYazisi = "Hoşgeldiniz! Yarışın Başlamasına Kalan Süre : ";

    void Start()
    {
        ilkYazi();
        Debug.Log("--------------------------------------------");
        yolDurumu();
        Debug.Log("--------------------------------------------");
        puanTablosu();

    }

    void puanTablosu()
    {

        if (puan > 75)
        {
            Debug.Log("Tebrikler! Yüksek Puan Aldınız");
        }
        else if (puan > 50)
        {
            Debug.Log("Tebrikler! Normal Puan Aldınız");
        }
        else if (puan > 25)
        {
            Debug.Log("Tebrikler! Düşük Puan Aldınız");
        }
        else
        {
            Debug.Log("Maalesef! En Düşük Sıralamaya Girdiniz");
        }
    }

    void yolDurumu()
    {
        // Yarışın toplam uzunluğu 5.0 metre olarak kabul edildi. Case 1.0 olduğunda yarışın 1.0 metresinin geçildiği varsayılmıştır.
        switch (yol)
        {
            case 1.0f:
                Debug.Log("Yarışa Kalan Mesafe : 4.0 Metre");
                break;
            case 2.0f:
                Debug.Log("Yarışa Kalan Mesafe : 3.0 Metre");
                break;
            case 3.0f:
                Debug.Log("Yarışa Kalan Mesafe : 2.0 Metre");
                break;
            case 4.0f:
                Debug.Log("Yarışa Kalan Mesafe : 1.0 Metre");
                break;
            default:
                Debug.Log("Tebrikler! Yarışı Tamamladınız");
                break;
        }
    }

    void ilkYazi()
    {
        int sayac = 5;
        while (sayac >= 0)
        {
            if (sayac > 0)
            {
                Debug.Log(girisYazisi + sayac + " Saniye");
                sayac--;
            }
            else
            {
                Debug.Log("Yarış Başlıyor...");
                sayac--;
            }
        }

    }



    void Update()
    {

    }
}
