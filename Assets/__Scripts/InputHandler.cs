using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private InputSystem _input;

    private void Awake()
    {
        _input = new InputSystem();
        _input.Player.Jump.performed += context => Player.S.Jump();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }
}
