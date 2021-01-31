using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteksiLantai : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            playerMovement.ActivateTagLantai2();
            Invoke("DestroyGameobject", 0.7f);
        }
    }

    void DestroyGameobject()
    {
        Destroy(gameObject);
    }
}
