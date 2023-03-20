using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    Player _player;
    void Start()
    {
        _player = GetComponent<Player>();
    }
    public void OnDirection(InputAction.CallbackContext context)
    {
        float dir = context.ReadValue<float>();
        _player.Direction = dir;
    }
    public void OnRun(InputAction.CallbackContext context)
    {
        if (context.started)
            _player.IsHoldingRun = true;
        else if (context.canceled)
            _player.IsHoldingRun = false;
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
            _player.IsHoldingJump = true;
        else if (context.canceled)
            _player.IsHoldingJump = false;
    }
}
