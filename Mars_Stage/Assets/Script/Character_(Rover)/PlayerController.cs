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

    [SerializeField] private float _gravity;
    [SerializeField] private float _speed;
    [SerializeField] private float _backSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _speedRotateWheels;

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
        movement *= _speed * Time.fixedDeltaTime;

        //move back
        if (moveY < 0)
        {
            movement *= _backSpeed * Time.fixedDeltaTime;
            
            
            WheelRotateFront();

        }

        // move front
        if (moveY > 0)
        {
            movement *= _speed * Time.fixedDeltaTime;
            
            WheelRotateBack();
            
            
        }
        else
        {
            // _speedRotateWheels = 0f;
        }

        

        _rb.MovePosition(_rb.position + movement);

    }

    public void Rotate()
    {
        // Récupérer l'axe de rotation
        float rotation = Gamepad.current.rightStick.x.ReadValue();

        // Calculer la rotation en fonction de l'axe
        Quaternion deltaRotation = Quaternion.Euler(Vector3.up * (rotation * _rotateSpeed * Time.fixedDeltaTime));
        _rb.MoveRotation(_rb.rotation * deltaRotation);

        // WheelRotate();



    }

    public void WheelRotateFront()
    {
        foreach (Transform transform in _transformWheels)
        {
            transform.rotation *= Quaternion.Euler(0, _speedRotateWheels *_speed  * Time.deltaTime, 0);
        }
    }

    public void WheelRotateBack()
    {
        foreach (Transform transform in _transformWheels)
        {
            transform.rotation *= Quaternion.Euler(0, -_speedRotateWheels *_backSpeed  * Time.deltaTime, 0);
        }
    }

}

