using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject sign;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            sign.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            sign.SetActive(false);
        }
    }
}
