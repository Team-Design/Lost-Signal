using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public static int IsInLantai;

    public Transform Player;
    public Transform Marker;

    //public Transform camera;
    public Animator anim;

    private void Awake()
    {

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Player.position = Marker.position;
            anim.Play("Camera Scroll");
            IsInLantai++;
        }
    }
}
