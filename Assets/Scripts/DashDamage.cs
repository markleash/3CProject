using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class DashDamage : MonoBehaviour
{
   public float damage;
   [SerializeField] private TwinStickMovement player;
   [SerializeField] private float knockbackCooldown;
   [SerializeField] private float knockbackForce;
   [SerializeField] private Rigidbody enemyRb;
   private NavMeshAgent enemyNav;
   private bool alreadyDamaged = false;
   

   private void Start()
   {
      this.enabled = false;
   }

   private void Update()
   {
      DodgeAction();
   }


   void OnTriggerEnter(Collider enemy)
   {
      
      GameObject enemyObject = enemy.gameObject;
      if (enemyObject.tag == "Enemy" && player.isDodging && !alreadyDamaged)
      {
         enemyObject.GetComponent<EnemyHealth>().TakeDamage(damage);
         enemyNav = enemyObject.GetComponent<NavMeshAgent>();
         enemyNav.enabled = false;
         enemyRb.constraints = RigidbodyConstraints.None;
         Knockback(enemyObject);
         StartCoroutine(KnockbackCD());
         enemyRb.constraints = RigidbodyConstraints.FreezeAll;
         enemyNav.enabled = true;
         alreadyDamaged = true;
      }
   }

   private void OnTriggerExit(Collider enemy)
   {
      GameObject enemyObject = enemy.gameObject;
      if (enemyObject.tag == "Enemy")
      {

         alreadyDamaged = false;

      }
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
      Debug.Log("Dodge enabled");

      yield return new WaitForSeconds(0.2f);
      this.enabled = false;
      yield return new WaitForSeconds(2f);
      this.enabled = true;


   }

   private void Knockback(GameObject enemy)
   {
      Debug.Log(("HOLA"));
      //enemy.transform.position += transform.forward * Time.deltaTime * knockbackForce;
      enemy.GetComponent<Rigidbody>().AddExplosionForce(knockbackForce, this.transform.position, 5f, 1f, ForceMode.Impulse);
   }

   private IEnumerator KnockbackCD()
   {
      yield return new WaitForSeconds(knockbackCooldown);
   }
}

