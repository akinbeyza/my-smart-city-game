using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CcoinToplama : MonoBehaviour
{
    public int PlayerCoin;
    public Text zaman, puan, durum;
    float zamanSayaci = 60;
    bool oyunDevam = true;
    bool oyunTamam = false;

    private void Update()
    {
        if (oyunDevam && !oyunTamam)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = (int)zamanSayaci + "";
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        string objIsmi = other.gameObject.name;
        if (objIsmi.Equals("Bitis2"))
        {
            oyunTamam = true;
            durum.text = "Oyunu tamamladýnýz. Tebrikler!";
        }
        else if (zamanSayaci < 0)
        {
            oyunDevam = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            PlayerCoin++;
            Destroy(other.gameObject);
            puan.text = PlayerCoin.ToString();
        }
        else if (other.gameObject.CompareTag("Coin25"))
        {
            SceneManager.LoadScene(0);
        }
    }
}

