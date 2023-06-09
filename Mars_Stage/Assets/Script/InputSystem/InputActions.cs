//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Script/InputSystem/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""RoverPlayer"",
            ""id"": ""dc68a83b-0928-490f-91a7-7af389985099"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""25de8de5-c55c-45b3-8794-0e74604273ec"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""19e20a9e-7910-4ef4-b908-59198452060b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Scan"",
                    ""type"": ""Button"",
                    ""id"": ""a4ef306a-fa33-4c71-aa24-ac0eefd7d8ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f5192990-87ef-432d-a91a-993f3ca7fa72"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""24ee7a22-f01b-483e-b7bd-7481739348d7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""385d1962-845f-4025-8a82-fddfaacd857f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""498e3f3a-ff12-4882-b86f-550017dfedfb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""36e15156-ddc8-454e-8558-41ab6f149eb4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5b593e9b-c397-4bfd-a223-4e256ae57ecb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""206ccff6-c2ef-4868-a01c-1b8ee56895fc"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d548fc3-5b9d-4dfe-9634-5d9ad335faba"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da2f1907-464b-4737-8fab-4eb1cb64745a"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d3f6133-585f-4dda-a675-14fb1eac1b76"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RoverPlayer
        m_RoverPlayer = asset.FindActionMap("RoverPlayer", throwIfNotFound: true);
        m_RoverPlayer_Move = m_RoverPlayer.FindAction("Move", throwIfNotFound: true);
        m_RoverPlayer_Reload = m_RoverPlayer.FindAction("Reload", throwIfNotFound: true);
        m_RoverPlayer_Scan = m_RoverPlayer.FindAction("Scan", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // RoverPlayer
    private readonly InputActionMap m_RoverPlayer;
    private IRoverPlayerActions m_RoverPlayerActionsCallbackInterface;
    private readonly InputAction m_RoverPlayer_Move;
    private readonly InputAction m_RoverPlayer_Reload;
    private readonly InputAction m_RoverPlayer_Scan;
    public struct RoverPlayerActions
    {
        private @InputActions m_Wrapper;
        public RoverPlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_RoverPlayer_Move;
        public InputAction @Reload => m_Wrapper.m_RoverPlayer_Reload;
        public InputAction @Scan => m_Wrapper.m_RoverPlayer_Scan;
        public InputActionMap Get() { return m_Wrapper.m_RoverPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RoverPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IRoverPlayerActions instance)
        {
            if (m_Wrapper.m_RoverPlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_RoverPlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_RoverPlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_RoverPlayerActionsCallbackInterface.OnMove;
                @Reload.started -= m_Wrapper.m_RoverPlayerActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_RoverPlayerActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_RoverPlayerActionsCallbackInterface.OnReload;
                @Scan.started -= m_Wrapper.m_RoverPlayerActionsCallbackInterface.OnScan;
                @Scan.performed -= m_Wrapper.m_RoverPlayerActionsCallbackInterface.OnScan;
                @Scan.canceled -= m_Wrapper.m_RoverPlayerActionsCallbackInterface.OnScan;
            }
            m_Wrapper.m_RoverPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Scan.started += instance.OnScan;
                @Scan.performed += instance.OnScan;
                @Scan.canceled += instance.OnScan;
            }
        }
    }
    public RoverPlayerActions @RoverPlayer => new RoverPlayerActions(this);
    public interface IRoverPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnScan(InputAction.CallbackContext context);
    }
}
