using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lvl2sUI : MonoBehaviour
{
    public void Lvl2Btn()
    {
        SceneManager.LoadScene(5);
    }
    public void Level2UI()
    {
        SceneManager.LoadScene(4);
    }
}
