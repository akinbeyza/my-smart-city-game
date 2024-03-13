using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinToplama : MonoBehaviour
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
            zaman.text = ((int)zamanSayaci).ToString();

        }
    }
    private void OnCollisionEnter(Collision other)
    {
        string objIsmi = other.gameObject.name;
        if (objIsmi.Equals("Bitis"))
        {
            oyunTamam = true;
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
        else if (other.gameObject.CompareTag("Coin15")) // "Coin15" etiketini buraya taþýdýk
        {
            SceneManager.LoadScene(4);
        }
    }
}