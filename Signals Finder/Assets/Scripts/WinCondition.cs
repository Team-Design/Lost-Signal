using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject WinMenu;

    private void OnTriggerEnter2D(Collider2D target)
    {
        // play timeline
        // showing a lanjutkan atau kembali ke level menu 
        WinMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
