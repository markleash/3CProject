using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class KnockBackTrigger : MonoBehaviour
{

    [SerializeField] private float knockbackStrenght;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();

        if(rb != null)
        {
            Vector3 dir = collision.transform.position - transform.position;

            dir.y = 0;

            rb.AddForce(dir.normalized * knockbackStrenght, ForceMode.Impulse);
        }
    
    
    }













}
