using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public static int IsInLantai;

    public Transform Player;
    public Transform Marker;

    //public Transform camera;
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;

    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;

    private void Awake()
    {

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Player.position = Marker.position;
            anim1.Play("Camera Scroll");
            IsInLantai++;

            if (IsInLantai == 1)
            {
                anim1.Play("Camera Scroll");
            }
            if (IsInLantai == 2)
            {
                Invoke("SetActiveCam2", 2.2f);
                Invoke("SetDeactiveCam1", 2.1f);
                anim2.Play("Camera Scroll1");
            }
            if (IsInLantai == 3)
            {
                anim3.Play("Camera Scroll1");
            }
            if (IsInLantai == 4)
            {
                anim4.Play("Camera Scroll");
            }
            if (IsInLantai == 5)
            {
                anim5.Play("Camera Scroll");
            }
        }
    }

    void SetDeactiveCam1()
    {
        cam1.SetActive(false);
    }
    void SetDeactiveCam2()
    {
        cam2.SetActive(false);
    }
    void SetDeactiveCam3()
    {
        cam3.SetActive(false);
    }
    void SetDeactiveCam4()
    {
        cam4.SetActive(false);
    }
    void SetDeactiveCam5()
    {
        cam5.SetActive(false);
    }

    void SetActiveCam1()
    {
        cam1.SetActive(true);
    }
    void SetActiveCam2()
    {
        cam2.SetActive(true);
    }
    void SetActiveCam3()
    {
        cam3.SetActive(true);
    }
    void SetActiveCam4()
    {
        cam4.SetActive(true);
    }
    void SetActiveCam5()
    {
        cam5.SetActive(true);
    }
}
