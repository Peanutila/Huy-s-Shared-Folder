using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    Moving player;
    Weapon gun;
    CharacterInput characterInput;
    CharacterInput.OnFootActions onFoot;
    
    void Awake()
    {
        characterInput = new CharacterInput();
        onFoot = characterInput.OnFoot;
        player = GetComponent<Moving>();
        gun = GameObject.Find("Barrel").GetComponent<Weapon>();
        onFoot.Jump.performed += ctx => player.Jump();
        onFoot.Shoot.performed += ctx => gun.Spawn();   
    }
    
    void FixedUpdate() {
        player.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }
    private void OnEnable() {
        onFoot.Enable();
    }
    private void OnDisable() {
        onFoot.Disable();
    }
    
}
