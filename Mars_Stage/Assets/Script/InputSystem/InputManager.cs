using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using  UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerController _playerController;
    private InputAction _moveActions; 

    [Header("Scanner")]
    [SerializeField] private GameObject _scanPrefab; 
    [SerializeField] private Transform _spawnScanner; 
    // [SerializeField] private float _speed;
    // private Quaternion _lastRotation;

    public void Awake()
    {
        _playerController = GetComponent<PlayerController>();
        _playerInput = GetComponent<PlayerInput>();
        _moveActions = _playerInput.actions.FindAction("Move");
        _moveActions = _playerInput.actions.FindAction("Scan");
    }

    // public void OnMove()
    // {
    //     Vector2 direction = _moveActions.ReadValue<Vector2>();
    //     Vector3 directConvert = new Vector3(direction.x, 0, direction.y);
    //     Debug.Log("Test manette");
    // }

    public void FixedUpdate()
    {
        _playerController.Move();
        _playerController.Rotate();
    }

    public void OnReload()
    {
        SceneManager.LoadScene("S_CreationTerrain_Rover");
    }

    public void OnScan()
    {
        Instantiate(_scanPrefab, transform.position, Quaternion.identity);
        
    }
}
  