using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenPickup : MonoBehaviour
{
    public AudioClip RegSound;
    public AudioSource audioSource;
    PlayerHealth target;

    [SerializeField] float healthRegened = -1f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && (target.hitPoints< 3))
        {
            target.TakeDamage(healthRegened);
            audioSource.PlayOneShot(RegSound);
            Destroy(gameObject);
        }
    }
}
