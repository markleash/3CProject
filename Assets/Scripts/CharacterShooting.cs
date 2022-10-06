using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterShooting : MonoBehaviour
{
    public Gun gun;

    void OnShoot(InputValue Shoot)
    {
        if (Shoot.isPressed)
        {
            gun.Shoot();    
        }
    }

    void OnReload(InputValue Reload)
    {
        if (Reload.isPressed)
        {
            gun.Reload();
        }
    }
}