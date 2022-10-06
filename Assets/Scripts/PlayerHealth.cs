using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Damage/Damage");
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Death/Death");
        }
    }
}
