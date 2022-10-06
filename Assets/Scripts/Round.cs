using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    
    public int damage;
    public float enemyDamage;

    
    
    void OnCollisionEnter(Collision collision) 
    {
        GameObject collisionObject = collision.gameObject ;
        if (collisionObject.tag == "Level")
        {
            Destroy(gameObject);
        }

        if (collisionObject.tag == "Player")
        {
            collisionObject.GetComponent<PlayerHealth>().TakeDamage(damage);


            Destroy(gameObject);
        }
        
        else if (collisionObject.tag == "Enemy")
        {
            collisionObject.GetComponent<EnemyHealth>().TakeDamage(enemyDamage);
            Destroy(gameObject);
        }
    }
}