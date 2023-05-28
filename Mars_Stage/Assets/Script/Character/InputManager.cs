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
        _moveActions = _playerInput.actions.FindAction("Move");
    }

    public void OnMove()
    {
        Vector2 direction = _moveActions.ReadValue<Vector2>();
        Vector3 directionConvert = new Vector3(direction.x, 0f, direction.y);
        // Vector3 velocity = directionConvert * _speed;
        _playerController.Direction = directionConvert;

        _playerController.ControlRotate();


    }
}
