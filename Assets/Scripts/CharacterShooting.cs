using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterShooting : MonoBehaviour
{
    public PlayerControls playerControls;
    public Gun gun;
    public InputAction fireValue;
    public TwinStickMovement movement;

    /*void Update() {
  
        //if (Gamepad.current.rightTrigger.wasPressedThisFrame && Input.GetKeyDown(KeyCode.Mouse0))
        //playerControls.Controls.Shoot.IsPressed()
        if(playerControls.FindAction("Shoot").WasPressedThisFrame())
        {
            Debug.Log("AAAAAAAAHH");
            //gun.Shoot();
        }

        if(Input.GetKeyDown(KeyCode.R)) {
            gun.Reload();
        }
        
    }*/
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