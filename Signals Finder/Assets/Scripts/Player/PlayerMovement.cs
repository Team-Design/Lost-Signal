using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float move_speed;

    private bool playerIsInArea;
    private bool isChooseDoor1;
    private bool isChooseDoor2;
    private bool isChooseDoor3;
    private bool isChooseDoor4;
    private bool isChooseDoor5;
    private bool isChooseDoor6;

    private Rigidbody2D rb;

    public GameObject[] doors;
    public GameObject portal;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void SetBack()
    {
        foreach (GameObject door in doors)
        {
            if (door != null)
            {
                door.SetActive(true);
            }
            
        }
    }

    void SetFalse()
    {
        isChooseDoor1 = false;
        isChooseDoor2 = false;
        isChooseDoor3 = false;
        isChooseDoor4 = false;
        isChooseDoor5 = false;
        isChooseDoor6 = false;
    }

    private void FixedUpdate()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * move_speed, rb.velocity.y);

        // ============= 1 =======================
        if (isChooseDoor2 && isChooseDoor3)
        {
            // MATCHED
            Destroy(doors[1].gameObject);
            Destroy(doors[2].gameObject);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }

        // =======================================



        // ================ 2 =======================
        if (isChooseDoor1 && isChooseDoor5)
        {
            // MATCHED

            Destroy(doors[0].gameObject);
            Destroy(doors[4].gameObject);

            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        // =========================================



        // ================ 3 =======================
        if (isChooseDoor4 && isChooseDoor6)
        {
            Destroy(doors[3].gameObject);
            Destroy(doors[5].gameObject);

            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }



        if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door4") == null &&
            GameObject.FindWithTag("door5") == null && GameObject.FindWithTag("door6") == null
            )
        {
            portal.SetActive(true);
        }
    }

    // 2,3 = 1 | 1,5 = 2 | 4,6 = 3

    private void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "door1")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door1").SetActive(false);
                isChooseDoor1 = true;
            }
        }
        if (target.tag == "door2")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door2").SetActive(false);
                isChooseDoor2 = true;
            }
        }
        if (target.tag == "door3")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door3").SetActive(false);
                isChooseDoor3 = true;
            }
        }
        if (target.tag == "door4")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door4").SetActive(false);
                isChooseDoor4 = true;
            }
        }
        if (target.tag == "door5")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door5").SetActive(false);
                isChooseDoor5 = true;
            }
        }
        if (target.tag == "door6")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door6").SetActive(false);
                isChooseDoor6 = true;
            }
        }
    }
}
