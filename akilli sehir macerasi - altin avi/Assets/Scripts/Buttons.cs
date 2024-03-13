using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void BaslaBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void CikisBtn()
    {
        print("Oyundan Çýkýþ Yaptýn!");
        Application.Quit();
    }
    public void EntranceScene()
    {
        SceneManager.LoadScene(0);
    }
}
