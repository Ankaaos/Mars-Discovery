using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerController _playerController;
    private InputAction _moveActions;
    // [SerializeField] private float _speed;
    // private Quaternion _lastRotation;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
        _playerInput = GetComponent<PlayerInput>();
        // _moveActions = _playerInput.actions.FindAction("Move");
    }

    private void FixedUpdate()
    {
        _playerController.Move();
        _playerController.Rotate();
    }
}
