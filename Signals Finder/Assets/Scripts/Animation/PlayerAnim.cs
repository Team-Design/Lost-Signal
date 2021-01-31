using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        if (direction != 0)
        {
            anim.SetBool("Running", true);
            Debug.Log("Runinng!");
        }
        else
        {
            anim.SetBool("Running", false);
        }            
    }
}
