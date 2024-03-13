using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Envanter : MonoBehaviour
{
    public int PlayerCoin = 0;
    void Start()
    {
        // PlayerPrefs'ten kaydedilmi� coinSayisi de�erini al
        if (PlayerPrefs.HasKey(nameof(PlayerCoin)))
        {
            PlayerCoin = PlayerPrefs.GetInt(nameof(PlayerCoin));
        }
    }
    void Update()
    {
        // �htiyaca g�re g�ncelleme yap�labilir
    }
    public void CoinSayisiniArttir()
    {
        PlayerCoin++;
        // G�ncellenen coinSayisi de�erini PlayerPrefs'e kaydet
        PlayerPrefs.SetInt(nameof(PlayerCoin), PlayerCoin);
    }
}

