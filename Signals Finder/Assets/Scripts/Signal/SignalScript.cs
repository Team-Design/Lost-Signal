using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignalScript : MonoBehaviour
{
    private Slider signal_bar;

    public GameObject GameOverUI;

    public float signal_lost_time;

    private void Awake()
    {
        signal_bar = GetComponent<Slider>();
    }

    private void Update()
    {
        signal_bar.value -= signal_lost_time * Time.deltaTime;

        if (signal_bar.value <= 0)
        {
            // ui gagal muncul
            GameOverUI.SetActive(true);
        }
    }
}
