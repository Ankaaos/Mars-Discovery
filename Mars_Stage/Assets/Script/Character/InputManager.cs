using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerController _playerController;
    private InputAction _moveActions;
    private Rigidbody _rb;
    [SerializeField]private float _speed;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
        _playerInput = GetComponent<PlayerInput>();
        _moveActions = _playerInput.actions.FindAction("Move");
        _rb = GetComponent<Rigidbody>();

    }

    public void OnMove()
    {
        
        Vector2 direction = _moveActions.ReadValue<Vector2>();
        Vector3 directionConvert = new Vector3(direction.x, 0f, direction.y);
        _rb.velocity = directionConvert * Time.fixedDeltaTime * _speed;

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionConvert), 1f);
        

        // Debug.Log("test");
    }
}
