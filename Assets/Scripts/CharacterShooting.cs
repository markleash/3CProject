using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShooting : MonoBehaviour
{
    public Gun gun;

    void Update() {
        if(Input.GetMouseButton(0)) {
            gun.Shoot();
        }

        if(Input.GetKeyDown(KeyCode.R)) {
            gun.Reload();
        }
    }
}