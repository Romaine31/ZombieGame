//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Onfoot"",
            ""id"": ""ca59afcb-c67c-41b3-b098-9c8957553f32"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""4dc16d7c-0167-47d7-b404-1d7088b734d0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""98a8efcc-f75f-43b1-aa88-326df2ef2b15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""a6199f9a-6b76-4ecf-97fc-de3920e28b4a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""f09390f3-999c-4b9c-8d27-f04c968f74d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""6bb0c6ca-3b3c-4272-817e-fb75018b653d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""a13b0fbd-c810-4e24-8bec-3b57d10e04da"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ea9e03f5-f4aa-4f5e-a00b-dc3b2d637c75"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""db41e30b-d367-437b-8c08-21faae7df988"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5b036395-70e8-48b2-b031-de5a9fceeb83"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1260ca2c-e0dc-4aa6-be6b-f8b6951f0d63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b03078b6-8553-4f89-9fd5-850651c1fb88"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""140925ac-1acf-4cae-9144-f30498a0f8b5"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a21b9cff-16ec-4ff4-bfe8-0004672766fc"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81b74fcb-a2a2-47c0-b4d7-9b6155bbece1"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Onfoot
        m_Onfoot = asset.FindActionMap("Onfoot", throwIfNotFound: true);
        m_Onfoot_Movement = m_Onfoot.FindAction("Movement", throwIfNotFound: true);
        m_Onfoot_Jump = m_Onfoot.FindAction("Jump", throwIfNotFound: true);
        m_Onfoot_Look = m_Onfoot.FindAction("Look", throwIfNotFound: true);
        m_Onfoot_Sprint = m_Onfoot.FindAction("Sprint", throwIfNotFound: true);
        m_Onfoot_Crouch = m_Onfoot.FindAction("Crouch", throwIfNotFound: true);
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

    // Onfoot
    private readonly InputActionMap m_Onfoot;
    private IOnfootActions m_OnfootActionsCallbackInterface;
    private readonly InputAction m_Onfoot_Movement;
    private readonly InputAction m_Onfoot_Jump;
    private readonly InputAction m_Onfoot_Look;
    private readonly InputAction m_Onfoot_Sprint;
    private readonly InputAction m_Onfoot_Crouch;
    public struct OnfootActions
    {
        private @PlayerInput m_Wrapper;
        public OnfootActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Onfoot_Movement;
        public InputAction @Jump => m_Wrapper.m_Onfoot_Jump;
        public InputAction @Look => m_Wrapper.m_Onfoot_Look;
        public InputAction @Sprint => m_Wrapper.m_Onfoot_Sprint;
        public InputAction @Crouch => m_Wrapper.m_Onfoot_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_Onfoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnfootActions set) { return set.Get(); }
        public void SetCallbacks(IOnfootActions instance)
        {
            if (m_Wrapper.m_OnfootActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_OnfootActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_OnfootActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_OnfootActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_OnfootActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_OnfootActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_OnfootActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_OnfootActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_OnfootActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_OnfootActionsCallbackInterface.OnLook;
                @Sprint.started -= m_Wrapper.m_OnfootActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_OnfootActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_OnfootActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_OnfootActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_OnfootActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_OnfootActionsCallbackInterface.OnCrouch;
            }
            m_Wrapper.m_OnfootActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
            }
        }
    }
    public OnfootActions @Onfoot => new OnfootActions(this);
    public interface IOnfootActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
}
