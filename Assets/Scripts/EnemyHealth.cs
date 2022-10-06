using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private ParticleSystem deathParticles;
    

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        particles.Play();
        
        if (hitPoints <= 0)
        {
            
            deathParticles.Play();
            FMODUnity.RuntimeManager.PlayOneShot("event:/Enemy/Death/Death");
            Destroy(gameObject);
        }
    }
}
