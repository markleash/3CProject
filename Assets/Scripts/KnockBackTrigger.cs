using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class KnockBackTrigger : MonoBehaviour
{

    [SerializeField] private float knockbackStrenght;
    private Vector3 pushDirection;
    [SerializeField] private CharacterController controller;
    
    private void OnCollisionEnter(Collision collision)
    {
        GameObject collisionObject = collision.gameObject;

        if(collisionObject.tag == "Player")
        {
            Debug.Log("Hit");
            /*Vector3 dir = collision.transform.position - transform.position;

            dir.y = 0;

            rb.AddForce(dir.normalized * knockbackStrenght, ForceMode.Impulse);*/
            
          
        }
    
    
    }













}
