using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    private Vector3 dir;


    private void Update()
    {
        dir.z = _playerTransform.eulerAngles.y;
        transform.localEulerAngles = dir;

        Debug.Log(dir.z);    
    }
}
