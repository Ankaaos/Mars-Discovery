using System;
using UnityEngine;


public class RotateAntenne : MonoBehaviour
{   [SerializeField] private Transform _antenne;
    [SerializeField] private float _speedRotate;

    private void Update()
    {
        _antenne.rotation *= Quaternion.Euler(0, 0, _speedRotate * Time.deltaTime);
    }
}