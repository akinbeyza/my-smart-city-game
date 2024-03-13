using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lvl1sUI : MonoBehaviour
{
    public void Lvl1Btn()
    {
        SceneManager.LoadScene(3);
    }
    public void Level1UI()
    {
        SceneManager.LoadScene(2);
    }
}
