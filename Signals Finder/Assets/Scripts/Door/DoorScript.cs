using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool playerIsInArea;

    private int chooseChance;

    public GameObject sign;
    public GameObject[] doors;

    private bool isChooseDoor1, isChooseDoor2, isChooseDoor3;

    private void Awake()
    {
        isChooseDoor1 = false;
        isChooseDoor2 = false;
        isChooseDoor3 = false;
    }

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

    private void FixedUpdate()
    {
        chooseDoor();

        /*if (chooseChance >= 2)
        {
            doors[doors.Length].SetActive(true);
        }*/

        
    }

    void chooseDoor()
    {
        if (playerIsInArea && Input.GetKey(KeyCode.E) && GameObject.FindWithTag("door1"))
        {
            chooseChance++;
            gameObject.SetActive(false);

            isChooseDoor1 = true;
        }

        if(playerIsInArea && Input.GetKey(KeyCode.E) && GameObject.FindWithTag("door2"))
        {
            chooseChance++;
            gameObject.SetActive(false);

            isChooseDoor2 = true;
        }

        if (playerIsInArea && Input.GetKey(KeyCode.E) && GameObject.FindWithTag("door3"))
        {
            chooseChance++;
            //gameObject.SetActive(false);
            Destroy(gameObject);

            isChooseDoor3 = true;
        }



        // -----------------------------------------------
        if (GameObject.FindWithTag("door1") == null)
        {
            Destroy(GameObject.FindWithTag("door1"));
            // kondisi yang lainnya
        }
        if (GameObject.FindWithTag("door2") == null)
        {
            Destroy(GameObject.FindWithTag("door2"));

            // kondisi yang lainnya
        }
        if (GameObject.FindWithTag("door3") == null)
        {
            Destroy(GameObject.FindWithTag("door3"));

            // kondisi yang lainnya
        }

        // -----------------------------------------------

        if (isChooseDoor1 == true && isChooseDoor2 == true)
        {
            Debug.Log("test");
        }
    }

}
