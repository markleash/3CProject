using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DashDamage : MonoBehaviour
{
   public float damage;

   private void Awake()
   {
      this.enabled =false;
   }

 
   
   void OnDodge(InputValue Dodge)
   {
      if (Dodge.isPressed )
      {
         DodgeAction();
      }
   }
   public void DodgeAction()
   {

      StartCoroutine(DodgeTimer());
      
   }
    
   public IEnumerator DodgeTimer()
   {
      this.enabled = true;
      void OnTriggerEnter(Collider enemy)
      {
      
         GameObject enemyObject = enemy.gameObject;
         if (enemyObject.tag == "Enemy")
         {
            enemyObject.GetComponent<EnemyHealth>().TakeDamage(damage);
         }
      }
      yield return new WaitForSeconds(0.2f);
      this.enabled = false;
      yield return new WaitForSeconds(2f);
      this.enabled = true;


   }
}
