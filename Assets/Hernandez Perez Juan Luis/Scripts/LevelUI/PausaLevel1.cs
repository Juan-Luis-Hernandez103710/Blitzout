using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaLevel1 : MonoBehaviour
{

    public GameObject panelMenu;

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        panelMenu.SetActive(true);

        Time.timeScale = 0f;
    }

    public void ReturnPlay()
    {
        panelMenu.SetActive(false);

        Time.timeScale = 1f;
    }
}
