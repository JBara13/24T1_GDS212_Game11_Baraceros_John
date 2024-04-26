using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animation door;

    public AudioSource open;

    void OnTriggerStay()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            door.Play();
            open.Play();
        }
    }
}
