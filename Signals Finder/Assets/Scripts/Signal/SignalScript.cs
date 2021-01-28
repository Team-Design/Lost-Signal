using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignalScript : MonoBehaviour
{
    private Slider signal_bar;

    public float signal_lost_time = 0.05f;

    private void Awake()
    {
        signal_bar = GetComponent<Slider>();
    }

    private void Update()
    {
        signal_bar.value -= signal_lost_time * Time.deltaTime;
    }
}
