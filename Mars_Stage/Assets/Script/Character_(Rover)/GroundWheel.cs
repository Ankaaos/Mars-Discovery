using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundWheel : MonoBehaviour
{
    [SerializeField] private Transform[] _wheels;
    [SerializeField] private float _raycastDistance = 1f;

    private void Update()
    {
        foreach (Transform wheel in _wheels)
        {
            RaycastHit hitInfo;

            if (Physics.Raycast(wheel.position, Vector3.down, out hitInfo, _raycastDistance))
            {
                wheel.position = hitInfo.point + hitInfo.normal * _raycastDistance;

            }
            else
            {

            }
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        foreach (Transform wheel in _wheels)
        {
            Vector3 origin = wheel.position;
            Vector3 direction = -wheel.up;
            Gizmos.DrawRay(origin, direction * _raycastDistance);

        }
    }

}
