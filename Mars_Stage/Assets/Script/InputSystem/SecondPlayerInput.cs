using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SecondPlayerInput : MonoBehaviour
{
    private PlayerInput _secondPlayerInput;

    private void Start()
    {
        _secondPlayerInput = PlayerInput.GetPlayerByIndex(1);
    }

    private void Update()
    {
        if(_secondPlayerInput.actions["AButton"].ReadValue<float>() > 0)
        {
            Debug.Log("Second Player Input");
        }
    }
}
