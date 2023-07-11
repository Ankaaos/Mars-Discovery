using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Sirenix.OdinInspector;

public class PlayerController : MonoBehaviour
{
    private Vector3 _direction;
    public Vector3 Direction { get => _direction; set => _direction = value; }

    private Vector3 _velocity;

    [GUIColor("orange")]
    [BoxGroup("GRAVITY", centerLabel: true)]
    [SerializeField] private float _gravity;

    [Space]
    [GUIColor("cyan")]
    [BoxGroup("SPEED ALL", centerLabel: true)]
    [SerializeField] private float _moveSpeed;

    [GUIColor("green")]
    [BoxGroup("SPEED ALL", centerLabel: true)]
    [SerializeField] private float _frontSpeedRotateWheels;
    
    [GUIColor("green")]
    [BoxGroup("SPEED ALL", centerLabel: true)]
    [SerializeField] private float _backSpeedRotateWheels;

    [GUIColor("red")]
    [BoxGroup("SPEED ALL", centerLabel: true)]
    [Range(0, 150)][SerializeField] private float _rotateSpeedCamera;

    [Space]
    [GUIColor("grey")]
    [BoxGroup("TRANSFORM", centerLabel: true)]
    [SerializeField] private Transform[] _transformWheels;


    private Rigidbody _rb;
    private Quaternion _targetRotation;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();

    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    public void Move()
    {
        // Récupérer l'axe vertical du joystick gauche
        float moveY = Gamepad.current.leftStick.y.ReadValue();

        // Calculer le mouvement en fonction de l'axe vertical et de la rotation
        Vector3 movement = transform.forward * moveY;
        movement *= _moveSpeed * Time.fixedDeltaTime;

        //move back
        if (moveY < 0)
        {
            movement *= _backSpeedRotateWheels * Time.fixedDeltaTime;
            WheelRotateBack();
        }

        // move front
        if (moveY > 0)
        {
            movement *= _moveSpeed * Time.fixedDeltaTime;
            WheelRotateFront();
        }

        _rb.MovePosition(_rb.position + movement);
    }

    public void Rotate()
    {
        // Récupérer l'axe de rotation
        float rotation = Gamepad.current.rightStick.x.ReadValue();

        // Calculer la rotation en fonction de l'axe
        Quaternion deltaRotation = Quaternion.Euler(Vector3.up * (rotation * _rotateSpeedCamera * Time.fixedDeltaTime));
        _rb.MoveRotation(_rb.rotation * deltaRotation);
    }

    public void WheelRotateBack()
    {
        foreach (Transform transform in _transformWheels)
        {
            transform.rotation *= Quaternion.Euler(0, -_frontSpeedRotateWheels * _backSpeedRotateWheels * Time.deltaTime, 0);
        }
    }

    public void WheelRotateFront()
    {
        foreach (Transform transform in _transformWheels)
        {
            transform.rotation *= Quaternion.Euler(0, _frontSpeedRotateWheels * _moveSpeed * Time.deltaTime, 0);
        }
    }

}

