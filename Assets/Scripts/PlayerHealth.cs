using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int hitPoints = 300;
    public int currentHealth;
    public HealthBar healthBar;
   

    private void Start()
    {
        currentHealth = hitPoints;
        healthBar.SetMaxHealth(hitPoints);
    }
    

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
        healthBar.SetHealth(hitPoints);
        FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Damage/Damage");
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Death/Death");
        }
    }

    public void GainHealth(int health)
    {
        hitPoints += health;
        healthBar.SetHealth(hitPoints);
        if (hitPoints >= 300)
        {
            hitPoints = 300;
        }
    }
}
