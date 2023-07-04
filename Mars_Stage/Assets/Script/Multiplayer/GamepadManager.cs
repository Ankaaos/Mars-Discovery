using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class GamepadManager : MonoBehaviour
{
    public bool hasPlayer1Gamepad = false;
    public bool hasPlayer2Gamepad = false;
    private Gamepad player1Gamepad;
    private Gamepad player2Gamepad;

    private void OnEnable()
    {
        InputSystem.onDeviceChange += OnDeviceChange;
    }

    private void OnDisable()
    {
        InputSystem.onDeviceChange -= OnDeviceChange;
    }

    private void OnDeviceChange(InputDevice device, InputDeviceChange change)
    {
        if (change == InputDeviceChange.Added)
        {
            if (device is Gamepad gamepad)
            {
                if (!hasPlayer1Gamepad)
                {
                    hasPlayer1Gamepad = true;
                    player1Gamepad = gamepad;
                    Debug.Log("Manette assignée à Player 1.");
                }
                else if (!hasPlayer2Gamepad)
                {
                    hasPlayer2Gamepad = true;
                    player2Gamepad = gamepad;
                    Debug.Log("Manette assignée à Player 2.");
                }
                // Ajoutez des conditions supplémentaires pour plus de joueurs si nécessaire
            }
        }
        else if (change == InputDeviceChange.Removed)
        {
            if (device is Gamepad gamepad)
            {
                if (gamepad == player1Gamepad)
                {
                    hasPlayer1Gamepad = false;
                    player1Gamepad = null;
                    Debug.Log("Manette déconnectée de Player 1.");
                }
                else if (gamepad == player2Gamepad)
                {
                    hasPlayer2Gamepad = false;
                    player2Gamepad = null;
                    Debug.Log("Manette déconnectée de Player 2.");
                }
                // Gérez les déconnexions pour plus de joueurs si nécessaire
            }
        }
    }
}
