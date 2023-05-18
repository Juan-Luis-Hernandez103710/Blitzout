using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Paneles de UI")]
    public GameObject PanelLose;

    [SerializeField]private TMP_Text Text_Timer;

    [SerializeField]public float timerTime;
    private int minutes, seconds, cents;

    void Update()
    {
        timerTime -= Time.deltaTime;

        if(timerTime < 0)
        {
            timerTime = 0;
        }

        minutes = (int)(timerTime / 60f);
        seconds = (int)(timerTime - minutes * 60f);
        cents = (int)((timerTime - (int)timerTime) * 100f);

        Text_Timer.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);

        if(timerTime == 0)
        {
            PanelLose.SetActive(true);

            Time.timeScale = 0f;
        }
    }
}
