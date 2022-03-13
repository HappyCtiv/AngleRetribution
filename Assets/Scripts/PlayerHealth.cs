using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float hitPoints = 3f;
    public float maxHitPoints = 3f;
    //public Text countLives;
    public AudioClip HitSound;
    AudioSource audioSource;
    public RectTransform healthBarTransform;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        LivesCountText();
    }

    public void TakeDamage (float Damage)
    {
        hitPoints -= Damage;

        if (hitPoints<=0)
        {
           GetComponent<DeathHandeler>().HandleDeath();
           LivesCountText();
        }

        if (hitPoints > 0)
        {
            audioSource.PlayOneShot(HitSound);
            LivesCountText();
        }
    } 
    
    void LivesCountText() //lives counter
    {
        Vector3 newScale = healthBarTransform.localScale;
        newScale.x = hitPoints / maxHitPoints;
        healthBarTransform.localScale = newScale;
        //countLives.text = "Lives: " + hitPoints.ToString();
    }

}
