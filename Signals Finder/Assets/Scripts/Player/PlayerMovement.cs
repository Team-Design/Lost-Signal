using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float move_speed;

    private bool isChooseDoor1;
    private bool isChooseDoor2;
    private bool isChooseDoor2dan3;
    private bool isChooseDoor3;
    private bool isChooseDoor4;
    private bool isChooseDoor5;
    private bool isChooseDoor1dan5;
    private bool isChooseDoor6;
    private bool isChooseDoor7;
    private bool isChooseDoor8;
    private bool isChooseDoor9;
    private bool isChooseDoor10;
    private bool isChooseDoor11;
    private bool isChooseDoor12;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    public GameObject[] doors;
    public GameObject[] doors1;
    public GameObject[] doors2;
    public GameObject[] doors3;
    public GameObject[] doors4;
    public GameObject[] doors5;
    public GameObject[] doors6;
    public GameObject[] doors7;
    public GameObject[] doors8;
    public GameObject[] doors9;
    public GameObject[] doors10;
    public GameObject[] doors11;
    public GameObject[] doors12;
    public GameObject[] doors13;
    public GameObject[] doors14;
    public GameObject[] doors15;
    public GameObject[] doors16;
    public GameObject[] doors17;
    public GameObject[] doors18;

    public GameObject doorTiapLantai1;
    public GameObject doorTiapLantai2;
    public GameObject doorTiapLantai3;
    public GameObject doorTiapLantai4;
    public GameObject doorTiapLantai5;
    public GameObject doorTiapLantai6;
    public GameObject doorTiapLantai7;
    public GameObject doorTiapLantai8;
    public GameObject doorTiapLantai9;
    public GameObject doorTiapLantai10;
    public GameObject doorTiapLantai11;
    public GameObject doorTiapLantai12;
    public GameObject doorTiapLantai13;
    public GameObject doorTiapLantai14;
    public GameObject doorTiapLantai15;
    public GameObject doorTiapLantai16;


    public GameObject portal;
    public GameObject portal2;
    public GameObject portal3;
    public GameObject portal4;
    public GameObject portal5;
    public GameObject portal6;
    public GameObject portal7;
    public GameObject portal8;
    public GameObject portal9;
    public GameObject portal10;
    public GameObject portal11;
    public GameObject portal12;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        PortalScript.IsInLantai = 1;
    }

    void SetBack()
    {
        if (PortalScript.IsInLantai == 1)
        {
            foreach (GameObject door in doors)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }


        if (PortalScript.IsInLantai == 2)
        {
            foreach (GameObject door in doors1)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
            
        if (PortalScript.IsInLantai == 3)
        {
            foreach (GameObject door in doors2)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
        
        if (PortalScript.IsInLantai == 4)
        {
            foreach (GameObject door in doors3)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
        
        if (PortalScript.IsInLantai == 5)
        {
            foreach (GameObject door in doors4)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
        
        if (PortalScript.IsInLantai == 6)
        {
            foreach (GameObject door in doors5)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
        
        if (PortalScript.IsInLantai == 7)
        {
            foreach (GameObject door in doors6)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
        
        if (PortalScript.IsInLantai == 8)
        {
            foreach (GameObject door in doors7)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
        
        if (PortalScript.IsInLantai == 9)
        {
            foreach (GameObject door in doors8)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
        
        if (PortalScript.IsInLantai == 10)
        {
            foreach (GameObject door in doors9)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
        
        if (PortalScript.IsInLantai == 11)
        {
            foreach (GameObject door in doors10)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
            }
        }
        
        if (PortalScript.IsInLantai == 12)
        {
            foreach (GameObject door in doors11)
            {
                if (door != null)
                {
                    door.SetActive(true);
                }
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
        isChooseDoor7 = false;
        isChooseDoor8 = false;
        isChooseDoor9 = false;
        isChooseDoor10 = false;
        isChooseDoor11 = false;
        isChooseDoor12 = false;

        isChooseDoor1dan5 = false;
        isChooseDoor2dan3 = false;
    }

    void ActivateTagLantai1()
    {
        doors[0].gameObject.tag = "door1";
        doors[1].gameObject.tag = "door2";
        doors[2].gameObject.tag = "door3";
        doors[3].gameObject.tag = "door4";
        doors[4].gameObject.tag = "door5";
        doors[5].gameObject.tag = "door6";
        doors[6].gameObject.tag = "door7";
        doors[7].gameObject.tag = "door8";
        doors[8].gameObject.tag = "door9";
        doors[9].gameObject.tag = "door10";
        doors[10].gameObject.tag = "door11";
        doors[11].gameObject.tag = "door12";
        doors[12].gameObject.tag = "door2dan3";
        doors[13].gameObject.tag = "door1dan5";
    }
    public void ActivateTagLantai2()
    {
        doors1[0].gameObject.tag = "door1";
        doors1[1].gameObject.tag = "door2";
        doors1[2].gameObject.tag = "door3";
        doors1[3].gameObject.tag = "door4";
        doors1[4].gameObject.tag = "door5";
        doors1[5].gameObject.tag = "door6";
        doors1[6].gameObject.tag = "door7";
        doors1[7].gameObject.tag = "door8";
        doors1[8].gameObject.tag = "door9";
        doors1[9].gameObject.tag = "door10";
        doors1[10].gameObject.tag = "door11";
        doors1[11].gameObject.tag = "door12";
        doors1[12].gameObject.tag = "door2dan3";
        doors1[13].gameObject.tag = "door1dan5";
    }

    private void FixedUpdate()
    {

        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * move_speed, rb.velocity.y);

        if (rb.velocity.x >= 0)
        {
            spriteRenderer.flipX = true;
        }
        else 
        {
            spriteRenderer.flipX = false;
        }


        if (PortalScript.IsInLantai == 1)
        {
            /*if (Application.loadedLevelName == "Level3" || Application.loadedLevelName == "Level4" || Application.loadedLevelName == "Level")
            {
                doorTiapLantai2.SetActive(false);
            }*/
            
            foreach (GameObject door in doors1)
            {
                door.gameObject.tag = "Deactivate";
            }
        }
        if (PortalScript.IsInLantai == 2)
        {
            /*if (Application.loadedLevelName == "Level3" || Application.loadedLevelName == "Level4" || Application.loadedLevelName == "Level")
            {
                doorTiapLantai2.SetActive(true);
            }*/


        }

        // ============= 1 =======================
        if (isChooseDoor2 && isChooseDoor3)
        {
            if (Application.loadedLevelName == "Level2" || Application.loadedLevelName == "Level5")
            {
                // MATCHED
                if (PortalScript.IsInLantai == 1)
                {
                    Destroy(doors[1].gameObject);
                    Destroy(doors[2].gameObject);
                }
                if (PortalScript.IsInLantai == 2)
                {
                    Destroy(doors1[1].gameObject);
                    Destroy(doors1[2].gameObject);
                }
                if (PortalScript.IsInLantai == 3)
                {
                    Destroy(doors2[1].gameObject);
                    Destroy(doors2[2].gameObject);
                }
                if (PortalScript.IsInLantai == 4)
                {
                    Destroy(doors3[1].gameObject);
                    Destroy(doors3[2].gameObject);
                }
                if (PortalScript.IsInLantai == 5)
                {
                    Destroy(doors4[1].gameObject);
                    Destroy(doors4[2].gameObject);
                }
                if (PortalScript.IsInLantai == 6)
                {
                    Destroy(doors5[1].gameObject);
                    Destroy(doors5[2].gameObject);
                }
                if (PortalScript.IsInLantai == 7)
                {
                    Destroy(doors6[1].gameObject);
                    Destroy(doors6[2].gameObject);
                }
                if (PortalScript.IsInLantai == 8)
                {
                    Destroy(doors7[1].gameObject);
                    Destroy(doors7[2].gameObject);
                }
                if (PortalScript.IsInLantai == 9)
                {
                    Destroy(doors8[1].gameObject);
                    Destroy(doors8[2].gameObject);
                }
                if (PortalScript.IsInLantai == 10)
                {
                    Destroy(doors9[1].gameObject);
                    Destroy(doors9[2].gameObject);
                }
                if (PortalScript.IsInLantai == 11)
                {
                    Destroy(doors10[1].gameObject);
                    Destroy(doors10[2].gameObject);
                }
                if (PortalScript.IsInLantai == 12)
                {
                    Destroy(doors11[1].gameObject);
                    Destroy(doors11[2].gameObject);
                }

                SetFalse();
            }
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
        if (isChooseDoor2 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor1 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor4 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor5 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor6 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor7 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor8 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor9 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor10 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor11 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor2 && isChooseDoor12 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }

        if (isChooseDoor2dan3 && isChooseDoor1dan5)
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
        if (isChooseDoor3 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor1 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor4 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor5 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor6 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor7 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor8 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor9 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor10 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor11 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor3 && isChooseDoor12 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        // =======================================

        // (~~~~~~~~||~~~~~~~~)
        if (isChooseDoor2 && isChooseDoor3 && isChooseDoor2dan3)
        {
            if (PortalScript.IsInLantai == 1)
            {
                Destroy(doors[1].gameObject);
                Destroy(doors[2].gameObject);
                Destroy(doors[12].gameObject);
            }
            if (PortalScript.IsInLantai == 2)
            {
                Destroy(doors1[1].gameObject);
                Destroy(doors1[2].gameObject);
                Destroy(doors1[12].gameObject);
            }
            if (PortalScript.IsInLantai == 3)
            {
                Destroy(doors2[1].gameObject);
                Destroy(doors2[2].gameObject);
                Destroy(doors2[12].gameObject);
            }
            if (PortalScript.IsInLantai == 4)
            {
                Destroy(doors3[1].gameObject);
                Destroy(doors3[2].gameObject);
                Destroy(doors3[12].gameObject);
            }
            if (PortalScript.IsInLantai == 5)
            {
                Destroy(doors4[1].gameObject);
                Destroy(doors4[2].gameObject);
                Destroy(doors4[12].gameObject);
            }
            if (PortalScript.IsInLantai == 6)
            {
                Destroy(doors5[1].gameObject);
                Destroy(doors5[2].gameObject);
                Destroy(doors5[12].gameObject);
            }
            if (PortalScript.IsInLantai == 7)
            {
                Destroy(doors6[1].gameObject);
                Destroy(doors6[2].gameObject);
                Destroy(doors6[12].gameObject);
            }
            if (PortalScript.IsInLantai == 8)
            {
                Destroy(doors7[1].gameObject);
                Destroy(doors7[2].gameObject);
                Destroy(doors7[12].gameObject);
            }
            if (PortalScript.IsInLantai == 9)
            {
                Destroy(doors8[1].gameObject);
                Destroy(doors8[2].gameObject);
                Destroy(doors8[12].gameObject);
            }
            if (PortalScript.IsInLantai == 10)
            {
                Destroy(doors9[1].gameObject);
                Destroy(doors9[2].gameObject);
                Destroy(doors9[12].gameObject);
            }
            if (PortalScript.IsInLantai == 11)
            {
                Destroy(doors10[1].gameObject);
                Destroy(doors10[2].gameObject);
                Destroy(doors10[12].gameObject);
            }
            if (PortalScript.IsInLantai == 12)
            {
                Destroy(doors11[1].gameObject);
                Destroy(doors11[2].gameObject);
                Destroy(doors11[12].gameObject);
            }
            Debug.Log("berhasil");
            SetFalse();
        }

        // ================ 2 =======================
        if (isChooseDoor1 && isChooseDoor5)
        {
            if (Application.loadedLevelName == "Level2" || Application.loadedLevelName == "Level5")
            {
                // MATCHED
                if (PortalScript.IsInLantai == 1)
                {
                    Destroy(doors[0].gameObject);
                    Destroy(doors[4].gameObject);
                }
                if (PortalScript.IsInLantai == 2)
                {
                    Destroy(doors1[0].gameObject);
                    Destroy(doors1[4].gameObject);
                }
                if (PortalScript.IsInLantai == 3)
                {
                    Destroy(doors2[0].gameObject);
                    Destroy(doors2[4].gameObject);
                }
                if (PortalScript.IsInLantai == 4)
                {
                    Destroy(doors3[0].gameObject);
                    Destroy(doors3[4].gameObject);
                }
                if (PortalScript.IsInLantai == 5)
                {
                    Destroy(doors4[0].gameObject);
                    Destroy(doors4[4].gameObject);
                }
                if (PortalScript.IsInLantai == 6)
                {
                    Destroy(doors5[0].gameObject);
                    Destroy(doors5[4].gameObject);
                }
                if (PortalScript.IsInLantai == 7)
                {
                    Destroy(doors6[0].gameObject);
                    Destroy(doors6[4].gameObject);
                }
                if (PortalScript.IsInLantai == 8)
                {
                    Destroy(doors7[0].gameObject);
                    Destroy(doors7[4].gameObject);
                }
                if (PortalScript.IsInLantai == 9)
                {
                    Destroy(doors8[0].gameObject);
                    Destroy(doors8[4].gameObject);
                }
                if (PortalScript.IsInLantai == 10)
                {
                    Destroy(doors9[0].gameObject);
                    Destroy(doors9[4].gameObject);
                }
                if (PortalScript.IsInLantai == 11)
                {
                    Destroy(doors10[0].gameObject);
                    Destroy(doors10[4].gameObject);
                }
                if (PortalScript.IsInLantai == 12)
                {
                    Destroy(doors11[0].gameObject);
                    Destroy(doors11[4].gameObject);
                }

                SetFalse();
            }
            
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
        if (isChooseDoor1 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor2 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor3 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor4 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor6 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor7 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor8 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor9 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor10 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor11 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor1 && isChooseDoor12 && isChooseDoor1dan5)
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
        if (isChooseDoor5 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor2 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor3 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor4 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor6 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor7 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor8 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor9 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor10 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor11 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor5 && isChooseDoor12 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        // =========================================

        // (~~~~~~~~||~~~~~~~~)
        if (isChooseDoor1 && isChooseDoor5 && isChooseDoor1dan5)
        {
            // MATCHED
            if (PortalScript.IsInLantai == 1)
            {
                Destroy(doors[0].gameObject);
                Destroy(doors[4].gameObject);
                Destroy(doors[13].gameObject);
            }
            if (PortalScript.IsInLantai == 2)
            {
                Destroy(doors1[0].gameObject);
                Destroy(doors1[4].gameObject);
                Destroy(doors1[13].gameObject);
            }
            if (PortalScript.IsInLantai == 3)
            {
                Destroy(doors2[0].gameObject);
                Destroy(doors2[4].gameObject);
                Destroy(doors2[13].gameObject);
            }
            if (PortalScript.IsInLantai == 4)
            {
                Destroy(doors3[0].gameObject);
                Destroy(doors3[4].gameObject);
                Destroy(doors3[13].gameObject);
            }
            if (PortalScript.IsInLantai == 5)
            {
                Destroy(doors4[0].gameObject);
                Destroy(doors4[4].gameObject);
                Destroy(doors4[13].gameObject);
            }
            if (PortalScript.IsInLantai == 6)
            {
                Destroy(doors5[0].gameObject);
                Destroy(doors5[4].gameObject);
                Destroy(doors5[13].gameObject);
            }
            if (PortalScript.IsInLantai == 7)
            {
                Destroy(doors6[0].gameObject);
                Destroy(doors6[4].gameObject);
                Destroy(doors6[13].gameObject);
            }
            if (PortalScript.IsInLantai == 8)
            {
                Destroy(doors7[0].gameObject);
                Destroy(doors7[4].gameObject);
                Destroy(doors7[13].gameObject);
            }
            if (PortalScript.IsInLantai == 9)
            {
                Destroy(doors8[0].gameObject);
                Destroy(doors8[4].gameObject);
                Destroy(doors8[13].gameObject);
            }
            if (PortalScript.IsInLantai == 10)
            {
                Destroy(doors9[0].gameObject);
                Destroy(doors9[4].gameObject);
                Destroy(doors9[13].gameObject);
            }
            if (PortalScript.IsInLantai == 11)
            {
                Destroy(doors10[0].gameObject);
                Destroy(doors10[4].gameObject);
                Destroy(doors10[13].gameObject);
            }
            if (PortalScript.IsInLantai == 12)
            {
                Destroy(doors11[0].gameObject);
                Destroy(doors11[4].gameObject);
                Destroy(doors11[13].gameObject);
            }

            SetFalse();
        }

        // ================ 3 =======================
        if (isChooseDoor4 && isChooseDoor6)
        {
            if (PortalScript.IsInLantai == 1)
            {
                Destroy(doors[3].gameObject);
                Destroy(doors[5].gameObject);
            }
            if (PortalScript.IsInLantai == 2)
            {
                Destroy(doors1[3].gameObject);
                Destroy(doors1[5].gameObject);
            }
            if (PortalScript.IsInLantai == 3)
            {
                Destroy(doors2[3].gameObject);
                Destroy(doors2[5].gameObject);
            }
            if (PortalScript.IsInLantai == 4)
            {
                Destroy(doors3[3].gameObject);
                Destroy(doors3[5].gameObject);
            }
            if (PortalScript.IsInLantai == 5)
            {
                Destroy(doors4[3].gameObject);
                Destroy(doors4[5].gameObject);
            }
            if (PortalScript.IsInLantai == 6)
            {
                Destroy(doors5[3].gameObject);
                Destroy(doors5[5].gameObject);
            }
            if (PortalScript.IsInLantai == 7)
            {
                Destroy(doors6[3].gameObject);
                Destroy(doors6[5].gameObject);
            }
            if (PortalScript.IsInLantai == 8)
            {
                Destroy(doors7[3].gameObject);
                Destroy(doors7[5].gameObject);
            }
            if (PortalScript.IsInLantai == 9)
            {
                Destroy(doors8[3].gameObject);
                Destroy(doors8[5].gameObject);
            }
            if (PortalScript.IsInLantai == 10)
            {
                Destroy(doors9[3].gameObject);
                Destroy(doors9[5].gameObject);
            }
            if (PortalScript.IsInLantai == 11)
            {
                Destroy(doors10[3].gameObject);
                Destroy(doors10[5].gameObject);
            }
            if (PortalScript.IsInLantai == 12)
            {
                Destroy(doors11[3].gameObject);
                Destroy(doors11[5].gameObject);
            }

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
        if (isChooseDoor4 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor4 && isChooseDoor1dan5)
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
        if (isChooseDoor6 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor6 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        // =========================================



        // =============== 4 ========================
        if (isChooseDoor7 && isChooseDoor8)
        {
            if (PortalScript.IsInLantai == 1)
            {
                Destroy(doors[6].gameObject);
                Destroy(doors[7].gameObject);
            }
            if (PortalScript.IsInLantai == 2)
            {
                Destroy(doors1[6].gameObject);
                Destroy(doors1[7].gameObject);
            }
            if (PortalScript.IsInLantai == 3)
            {
                Destroy(doors2[6].gameObject);
                Destroy(doors2[7].gameObject);
            }
            if (PortalScript.IsInLantai == 4)
            {
                Destroy(doors3[6].gameObject);
                Destroy(doors3[7].gameObject);
            }
            if (PortalScript.IsInLantai == 5)
            {
                Destroy(doors4[6].gameObject);
                Destroy(doors4[7].gameObject);
            }
            if (PortalScript.IsInLantai == 6)
            {
                Destroy(doors5[6].gameObject);
                Destroy(doors5[7].gameObject);
            }
            if (PortalScript.IsInLantai == 7)
            {
                Destroy(doors6[6].gameObject);
                Destroy(doors6[7].gameObject);
            }
            if (PortalScript.IsInLantai == 8)
            {
                Destroy(doors7[6].gameObject);
                Destroy(doors7[7].gameObject);
            }
            if (PortalScript.IsInLantai == 9)
            {
                Destroy(doors8[6].gameObject);
                Destroy(doors8[7].gameObject);
            }
            if (PortalScript.IsInLantai == 10)
            {
                Destroy(doors9[6].gameObject);
                Destroy(doors9[7].gameObject);
            }
            if (PortalScript.IsInLantai == 11)
            {
                Destroy(doors10[6].gameObject);
                Destroy(doors10[7].gameObject);
            }
            if (PortalScript.IsInLantai == 12)
            {
                Destroy(doors11[6].gameObject);
                Destroy(doors11[7].gameObject);
            }

            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor7 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }

        if (isChooseDoor8 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor8 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        // ========================================

        // =============== 5 ======================
        if (isChooseDoor9 && isChooseDoor10)
        {
            if (PortalScript.IsInLantai == 1)
            {
                Destroy(doors[8].gameObject);
                Destroy(doors[9].gameObject);
            }
            if (PortalScript.IsInLantai == 2)
            {
                Destroy(doors1[8].gameObject);
                Destroy(doors1[9].gameObject);
            }
            if (PortalScript.IsInLantai == 3)
            {
                Destroy(doors2[8].gameObject);
                Destroy(doors2[9].gameObject);
            }
            if (PortalScript.IsInLantai == 4)
            {
                Destroy(doors3[8].gameObject);
                Destroy(doors3[9].gameObject);
            }
            if (PortalScript.IsInLantai == 5)
            {
                Destroy(doors4[8].gameObject);
                Destroy(doors4[9].gameObject);
            }
            if (PortalScript.IsInLantai == 6)
            {
                Destroy(doors5[8].gameObject);
                Destroy(doors5[9].gameObject);
            }
            if (PortalScript.IsInLantai == 7)
            {
                Destroy(doors6[8].gameObject);
                Destroy(doors6[9].gameObject);
            }
            if (PortalScript.IsInLantai == 8)
            {
                Destroy(doors7[8].gameObject);
                Destroy(doors7[9].gameObject);
            }
            if (PortalScript.IsInLantai == 9)
            {
                Destroy(doors8[8].gameObject);
                Destroy(doors8[9].gameObject);
            }
            if (PortalScript.IsInLantai == 10)
            {
                Destroy(doors9[8].gameObject);
                Destroy(doors9[9].gameObject);
            }
            if (PortalScript.IsInLantai == 11)
            {
                Destroy(doors10[8].gameObject);
                Destroy(doors10[9].gameObject);
            }
            if (PortalScript.IsInLantai == 12)
            {
                Destroy(doors11[8].gameObject);
                Destroy(doors11[9].gameObject);
            }

            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor9 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }

        if (isChooseDoor10 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor11)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor12)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor10 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        // =========================================



        // ================== 6 =======================
        if (isChooseDoor11 && isChooseDoor12)
        {
            if (PortalScript.IsInLantai == 1)
            {
                Destroy(doors[10].gameObject);
                Destroy(doors[11].gameObject);
            }
            if (PortalScript.IsInLantai == 2)
            {
                Destroy(doors1[10].gameObject);
                Destroy(doors1[11].gameObject);
            }
            if (PortalScript.IsInLantai == 3)
            {
                Destroy(doors2[10].gameObject);
                Destroy(doors2[11].gameObject);
            }
            if (PortalScript.IsInLantai == 4)
            {
                Destroy(doors3[10].gameObject);
                Destroy(doors3[11].gameObject);
            }
            if (PortalScript.IsInLantai == 5)
            {
                Destroy(doors4[10].gameObject);
                Destroy(doors4[11].gameObject);
            }
            if (PortalScript.IsInLantai == 6)
            {
                Destroy(doors5[10].gameObject);
                Destroy(doors5[11].gameObject);
            }
            if (PortalScript.IsInLantai == 7)
            {
                Destroy(doors6[10].gameObject);
                Destroy(doors6[11].gameObject);
            }
            if (PortalScript.IsInLantai == 8)
            {
                Destroy(doors7[10].gameObject);
                Destroy(doors7[11].gameObject);
            }
            if (PortalScript.IsInLantai == 9)
            {
                Destroy(doors8[10].gameObject);
                Destroy(doors8[11].gameObject);
            }
            if (PortalScript.IsInLantai == 10)
            {
                Destroy(doors9[10].gameObject);
                Destroy(doors9[11].gameObject);
            }
            if (PortalScript.IsInLantai == 11)
            {
                Destroy(doors10[10].gameObject);
                Destroy(doors10[11].gameObject);
            }
            if (PortalScript.IsInLantai == 12)
            {
                Destroy(doors11[10].gameObject);
                Destroy(doors11[11].gameObject);
            }

            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor11 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }

        if (isChooseDoor12 && isChooseDoor1)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor2)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor3)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor4)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor5)
        {
            Invoke("SetBack", 0.5f);

            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor6)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor7)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor8)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor9)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor10)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor2dan3)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }
        if (isChooseDoor12 && isChooseDoor1dan5)
        {
            Invoke("SetBack", 0.5f);


            SetFalse();
        }

        // 2,3 = 1 | 1,5 = 2 | 4,6 = 3 | 7,8 = 4 | 9,10 = 5 | 11,12 = 6
        // lvl 1 = 1,2
        // lvl 2 = 1,2,3
        // lvl 3 = 1,2,3,4
        // lvl 4 = 1,2,3,4,5
        // lvl 5 = 1,2,3,4,5,6

        if (Application.loadedLevelName == "Level1")
        {
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 1
            )
            {
                portal.SetActive(true);
            }

            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 2
            )
            {
                portal2.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 3
            )
            {
                portal3.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 4
            )
            {
                portal4.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 5
            )
            {
                portal5.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 6
            )
            {
                portal6.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 7
            )
            {
                portal7.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 8
            )
            {
                portal8.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 9
            )
            {
                portal9.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 10
            )
            {
                portal10.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 11
            )
            {
                portal11.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 12
            )
            {
                portal12.SetActive(true);
            }
        }
        if (Application.loadedLevelName == "Level2")
        {
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 1

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                Debug.Log("sukse");
                portal.SetActive(true);
            }

            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 2

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal2.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 3

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal3.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 4

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal4.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 5

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal5.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 6

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal6.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 7

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal7.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 8

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal8.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 9

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal9.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 10

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal10.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 11

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null
            )
            {
                portal11.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 12

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            )
            {
                portal12.SetActive(true);
            }
        }
        if (Application.loadedLevelName == "Level3")
        {
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 1

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal.SetActive(true);
            }

            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 2

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal2.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 3

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal3.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 4

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal4.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 5

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal5.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 6

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal6.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 7

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal7.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 8

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal8.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 9

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal9.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 10

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal10.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 11

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null
            )
            {
                portal11.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 12

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            )
            {
                portal12.SetActive(true);
            }
        }
        if (Application.loadedLevelName == "Level4")
        {
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 1

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal.SetActive(true);
            }

            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 2

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal2.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 3

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            && GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal3.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 4

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal4.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 5

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal5.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 6

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            && GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal6.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 7

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal7.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 8

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal8.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 9

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            && GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal9.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 10

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal10.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 11

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null
            )
            {
                portal11.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 12

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            && GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            )
            {
                portal12.SetActive(true);
            }
        }
        if (Application.loadedLevelName == "Level5")
        {
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 1

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            //&& GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal.SetActive(true);
            }

            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 2

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            //&& GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal2.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 3

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            && GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            //&& GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal3.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 4

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            && GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal4.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 5

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            //&& GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal5.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 6

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            //&& GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal6.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 7

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            && GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            //&& GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal7.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 8

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            && GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal8.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 9

            && GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            //&& GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal9.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 10

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            && GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            //&& GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal10.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 11

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            && GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            //&& GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null
            )
            {
                portal11.SetActive(true);
            }
            if (GameObject.FindWithTag("door1") == null && GameObject.FindWithTag("door2") == null &&
            GameObject.FindWithTag("door3") == null && GameObject.FindWithTag("door5") == null && PortalScript.IsInLantai == 12

            //&& GameObject.FindWithTag("door4") == null && GameObject.FindWithTag("door6") == null

            //&& GameObject.FindWithTag("door7") == null && GameObject.FindWithTag("door8") == null

            //&& GameObject.FindWithTag("door9") == null && GameObject.FindWithTag("door10") == null

            && GameObject.FindWithTag("door11") == null && GameObject.FindWithTag("door12") == null

            )
            {
                portal12.SetActive(true);
            }
        }


    }

    

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
        if (target.tag == "door7")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door7").SetActive(false);
                isChooseDoor7 = true;
            }
        }
        if (target.tag == "door8")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door8").SetActive(false);
                isChooseDoor8 = true;
            }
        }
        if (target.tag == "door9")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door9").SetActive(false);
                isChooseDoor9 = true;
            }
        }
        if (target.tag == "door10")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door10").SetActive(false);
                isChooseDoor10 = true;
            }
        }
        if (target.tag == "door11")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door11").SetActive(false);
                isChooseDoor11 = true;
            }
        }
        if (target.tag == "door12")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door12").SetActive(false);
                isChooseDoor12 = true;
            }
        }
        if (target.tag == "door2dan3")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door2dan3").SetActive(false);
                isChooseDoor2dan3 = true;
            }
        }
        if (target.tag == "door1dan5")
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject.FindWithTag("door1dan5").SetActive(false);
                isChooseDoor1dan5 = true;
            }
        }
    }
}
