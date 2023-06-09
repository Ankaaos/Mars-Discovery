using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow_Player : MonoBehaviour
{
    [SerializeField] private Transform _followPlayer;

    private void LateUpdate()
    {
        if(_followPlayer != null)
        {
            Vector2 pos = _followPlayer.position;

            transform.position = new Vector3(pos.x, 0, transform.position.z);
        }
    }
}
