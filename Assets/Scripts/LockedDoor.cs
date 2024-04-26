using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{

    public AudioSource lockedDoor;

    void OnTriggerStay()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            lockedDoor.Play();
        }
            
    }
}
