using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterHole : MonoBehaviour
{
    public EnemyAi enemy;
    
    private void OnEnterTirgger(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Physics.IgnoreCollision(enemy.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }


}
