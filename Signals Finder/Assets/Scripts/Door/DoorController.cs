using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    private string _doorname;

    private bool _isTerbuka = false;
    private bool playerIsInArea = false;

    private GameManager _gameManager;

    public string doorname
    {
        get
        {
            return _doorname;
        }
        set
        {
            _doorname = value;
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            playerIsInArea = true;
        }
        else
        {
            playerIsInArea = false;
        }
    }

    private void FixedUpdate()
    {
        OnKeyPressed();
    }

    void OnKeyPressed()
    {
        if (Input.GetKey(KeyCode.E) && playerIsInArea)
        {
            if (!_isTerbuka)
            {
                _isTerbuka = true;
            }
        }
        
    }

    public void ChangeSide()
    {
        if (!_isTerbuka)
        {
            _isTerbuka = true;
        }
        else
        {
            if (Input.GetKey(KeyCode.E) && playerIsInArea)
            {

            }
            _isTerbuka = false;
        }
    }
}
