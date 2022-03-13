using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{   
    [SerializeField] float timer;
    [SerializeField] float Speedboost = 4f;
    private float SpeedDecrease;
    
    public AudioClip SpeedSound;
    public AudioSource audioSource;

    void Start()
    {
        SpeedDecrease = 1/Speedboost;
    }

    void Update()
    {
        if (timer <=5)
        {
            timer -= Time.deltaTime;
        } 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        timer = 5f;
            if (timer > 0f)
            {
                FindObjectOfType<PlayerMovementScript>().SpeedMultipl(Speedboost);
                Debug.Log("Activating Speeeeeeed");
            }
        audioSource.PlayOneShot(SpeedSound);
        Destroy(gameObject);
        }
        
    }
}
