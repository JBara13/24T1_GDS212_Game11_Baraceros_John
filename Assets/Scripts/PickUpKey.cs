using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public Component doorCollider;
    public Component lockedDoorCollider;

    public GameObject keyGone;
    public AudioSource keyGet;
   

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            doorCollider.GetComponent<BoxCollider>().enabled = true;
            lockedDoorCollider.GetComponent<BoxCollider>().enabled = false;

        }

        if (Input.GetKey(KeyCode.E))
        {
            keyGet.Play();
            keyGone.SetActive(false);
        }
    }
}
