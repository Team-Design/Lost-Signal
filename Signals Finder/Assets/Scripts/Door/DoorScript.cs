using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private bool playerIsInArea;
    private static bool isChooseDoor1;
    private static bool isChooseDoor2;
    private static bool isChooseDoor3;

    public GameObject sign;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            playerIsInArea = true;
            sign.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            playerIsInArea = false;
            sign.SetActive(false);
        }
    }


    private void Update()
    {
        
    }

   


























}
