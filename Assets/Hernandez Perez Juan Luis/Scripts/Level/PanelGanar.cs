using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelGanar : MonoBehaviour
{
    public GameObject panelGanar;

    public void Ganar()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
