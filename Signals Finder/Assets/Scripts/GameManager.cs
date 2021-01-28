using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject _firstDoor;
    private GameObject _secondDoor;

    private bool _canFlip = true;

    private int _doorLeft;

    private float _timeBetweenFlips;

    public bool canFlip
    {
        get
        {
            return _canFlip;
        }
        set
        {
            _canFlip = value;
        }
    }

    public int doorLeft
    {
        get
        {
            return _doorLeft;
        }
        set
        {
            _doorLeft = value;
        }
    }

    public void AddDoor(GameObject door)
    {
        if (_firstDoor == null)
        {
            _firstDoor = door;
        }
        else
        {
            _secondDoor = door;
            _canFlip = false;

            if (CheckIfMatch())
            {
                DecreaseDoorCount();

                StartCoroutine(DeactiveDoor());
            }
            else
            {
                StartCoroutine(FlipCards());
            }
        }

        IEnumerator DeactiveDoor()
        {
            yield return new WaitForSeconds(_timeBetweenFlips);
            _firstDoor.GetComponent<DoorController>().ChangeSide();
            _secondDoor.GetComponent<DoorController>().ChangeSide();

            Reset();
        }

        IEnumerator FlipCards()
        {
            yield return new WaitForSeconds(_timeBetweenFlips);
            _firstDoor.GetComponent<DoorController>().ChangeSide();
            _secondDoor.GetComponent<DoorController>().ChangeSide();

            Reset();
        }
    }

    public void Reset()
    {
        _firstDoor = null;
        _secondDoor = null;

        _canFlip = true;
    }

    public void DecreaseDoorCount()
    {
        _doorLeft -= 2;

        if (_doorLeft <= 0)
        {
            // GAME OVER
        }
    }

    bool CheckIfMatch()
    {
        if (_firstDoor.GetComponent<DoorController>().doorname == _secondDoor.GetComponent<DoorController>().doorname)
        {
            return true;
        }
        return false;
    }
}
