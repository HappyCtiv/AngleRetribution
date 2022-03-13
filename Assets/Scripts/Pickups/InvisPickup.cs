using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InvisPickup : MonoBehaviour
{
    public AudioClip InvSound;
    public AudioSource audioSource;


    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<PlayerMovementScript>().isVisible = false;
            Debug.Log ("You are invisible");
            audioSource.PlayOneShot(InvSound);
            Destroy(gameObject);
        }

    }
}
