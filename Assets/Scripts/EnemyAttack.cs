using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 1f;
    PlayerMovementScript player;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        player = FindObjectOfType<PlayerMovementScript>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        if (player.isVisible)
        {
        target.TakeDamage(damage); //target.GetComponent<PlayerHealth>().TakeDamage(damage);
        Debug.Log("Hit");
        }

    }
}
