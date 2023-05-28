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
    [SerializeField] private float _maxRotateAngle;


    private Rigidbody _rb;

    private Quaternion _lastRotation;





    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        _velocity = _direction * _speed * Time.fixedDeltaTime;
        _rb.velocity = _velocity;

        _rb.AddForce(Vector3.down * _gravity * Time.fixedDeltaTime);

    }

    public void ControlRotate()
    {
        if (_direction.magnitude > 0.1f)
        {
            _lastRotation = Quaternion.LookRotation(_direction);
        }

        if (_lastRotation != transform.rotation)
        {
            float _angle = Quaternion.Angle(transform.rotation, _lastRotation);

            if (_angle > _maxRotateAngle)
            {
                Quaternion targetRotation = Quaternion.RotateTowards(transform.rotation, _lastRotation, _maxRotateAngle);
                transform.rotation = targetRotation;
            }
            else
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, _lastRotation, _rotateSpeed * Time.fixedDeltaTime);

            }
        }



        if (_direction.z < 0f)
        {
            _direction = _direction.normalized * _backSpeed;
        }
        else
        {
            _direction = _direction.normalized * _speed;
        }
    }




}
