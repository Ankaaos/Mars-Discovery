using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Sirenix.OdinInspector;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerController _playerController;
    private InputAction _moveActions;
    private DefaultInputActions _uiActions;

    


    [BoxGroup("Scanner", centerLabel: true)]
    [SerializeField] private GameObject _scanPrefab;

    [BoxGroup("Scanner", centerLabel: false)]
    [SerializeField] private Transform _spawnScanner;

    [GUIColor("cyan")]
    [BoxGroup("Couldown Scanner", centerLabel: true)]
    public float _scanCD = 3f;

    [GUIColor("cyan")]
    [BoxGroup("Couldown Scanner", centerLabel: true)]
    public bool _scanReady;

    [GUIColor("cyan")]
    [BoxGroup("Couldown Scanner", centerLabel: true)]
    public float _scanCDCurrent = 0f;
    
    //Input UI
    [GUIColor("cyan")]
    [BoxGroup("UI", centerLabel: true)]
    [SerializeField] private Slider _scanSlider;


    public void Awake()
    {
        _playerController = GetComponent<PlayerController>();
        _playerInput = GetComponent<PlayerInput>();
        _moveActions = _playerInput.actions.FindAction("Move");
        _moveActions = _playerInput.actions.FindAction("Scan");



    }

    private void Update()
    {
        if (_scanCDCurrent >= _scanCD)
        {
            _scanReady = true;
        }
        else
        {
            _scanCDCurrent += Time.deltaTime;
            _scanReady = false;
            _scanCDCurrent = Mathf.Clamp(_scanCDCurrent, 0, _scanCD);
        }

        _scanSlider.value = _scanCDCurrent / _scanCD;


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

        if (_scanReady)
        {
            Instantiate(_scanPrefab, transform.position, Quaternion.identity);
            _scanCDCurrent = 0f;

        }



    }


}
