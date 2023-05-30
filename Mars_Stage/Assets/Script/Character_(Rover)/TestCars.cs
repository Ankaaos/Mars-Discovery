using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestCars : MonoBehaviour
{
    private Rigidbody carRigidbody;
    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float _speedRotateWheels = 10f;
    [SerializeField] private float rotationSpeed = 100f;

    [SerializeField] private Transform[] _transformWheels;

    private void Awake()
    {
        carRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveTest();
    }

    public void MoveTest()
    {
        // Récupérer l'axe vertical du joystick gauche
        float moveY = Gamepad.current.leftStick.y.ReadValue();

        // Récupérer l'axe de rotation
        float rotation = Gamepad.current.rightStick.x.ReadValue();

        // Calculer la rotation en fonction de l'axe
        Quaternion deltaRotation = Quaternion.Euler(Vector3.up * (rotation * rotationSpeed * Time.fixedDeltaTime));
        carRigidbody.MoveRotation(carRigidbody.rotation * deltaRotation);

        // Calculer le mouvement en fonction de l'axe vertical et de la rotation
        Vector3 movement = transform.forward * moveY;
        movement *= movementSpeed * Time.fixedDeltaTime;

        carRigidbody.MovePosition(carRigidbody.position + movement);

        WheelRotate();

    }

    public void WheelRotate()
    {
        foreach(Transform transform in _transformWheels)
        {
            transform.rotation *= Quaternion.Euler( 0, Time.deltaTime * _speedRotateWheels,  0);
        }
    }
}
