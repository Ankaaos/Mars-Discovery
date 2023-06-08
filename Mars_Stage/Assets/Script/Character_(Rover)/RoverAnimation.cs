using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverAnimation : MonoBehaviour
{
    public Transform bodyTransform; // Référence au transform du corps du rover
    public float damping = 5f; // Valeur de l'amortissement

    private Vector3 targetPosition;
    private Vector2 moveInput;

    private void Start()
    {
        targetPosition = bodyTransform.position;
    }

    private void Update()
    {
        // // Récupérer l'entrée de mouvement à partir du nouveau système d'entrée
        // moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // Appliquer l'amortissement à la position du corps du rover
        Vector3 currentPosition = bodyTransform.position;
        // targetPosition += new Vector3(moveInput.x, 0f, moveInput.y);
        Vector3 newPosition = Vector3.Lerp(currentPosition, targetPosition, Time.deltaTime * damping);
        bodyTransform.position = newPosition;
    }
}