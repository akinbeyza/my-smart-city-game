using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Envanter : MonoBehaviour
{
    public int PlayerCoin = 0;
    void Start()
    {
        // PlayerPrefs'ten kaydedilmiþ coinSayisi deðerini al
        if (PlayerPrefs.HasKey(nameof(PlayerCoin)))
        {
            PlayerCoin = PlayerPrefs.GetInt(nameof(PlayerCoin));
        }
    }
    void Update()
    {
        // Ýhtiyaca göre güncelleme yapýlabilir
    }
    public void CoinSayisiniArttir()
    {
        PlayerCoin++;
        // Güncellenen coinSayisi deðerini PlayerPrefs'e kaydet
        PlayerPrefs.SetInt(nameof(PlayerCoin), PlayerCoin);
    }
}

