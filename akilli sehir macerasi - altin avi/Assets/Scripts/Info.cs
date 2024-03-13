using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{
    public void DevamBtn()
    {
        SceneManager.LoadScene(2);
    }
    public void Information()
    {
        SceneManager.LoadScene(1);
    }
}
