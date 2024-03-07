//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Logic/Input/PeegleInputs.inputactions
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

public partial class @PeegleInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PeegleInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PeegleInputs"",
    ""maps"": [
        {
            ""name"": ""MouseInput"",
            ""id"": ""45aa61a2-bd1f-4afe-b1e7-af1e9b880119"",
            ""actions"": [
                {
                    ""name"": ""clickDown"",
                    ""type"": ""Button"",
                    ""id"": ""a18f70a0-c57c-4c3f-9e0c-5090487d60f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ClickDownPos"",
                    ""type"": ""Value"",
                    ""id"": ""6d5baee1-f612-4d39-8653-d711c0dae7d0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bd070a85-d283-497f-b3c4-f39541ba0d2c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""clickDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3fa00d1-3693-4125-a8b3-ec54263077fa"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClickDownPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MouseInput
        m_MouseInput = asset.FindActionMap("MouseInput", throwIfNotFound: true);
        m_MouseInput_clickDown = m_MouseInput.FindAction("clickDown", throwIfNotFound: true);
        m_MouseInput_ClickDownPos = m_MouseInput.FindAction("ClickDownPos", throwIfNotFound: true);
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

    // MouseInput
    private readonly InputActionMap m_MouseInput;
    private IMouseInputActions m_MouseInputActionsCallbackInterface;
    private readonly InputAction m_MouseInput_clickDown;
    private readonly InputAction m_MouseInput_ClickDownPos;
    public struct MouseInputActions
    {
        private @PeegleInputs m_Wrapper;
        public MouseInputActions(@PeegleInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @clickDown => m_Wrapper.m_MouseInput_clickDown;
        public InputAction @ClickDownPos => m_Wrapper.m_MouseInput_ClickDownPos;
        public InputActionMap Get() { return m_Wrapper.m_MouseInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseInputActions set) { return set.Get(); }
        public void SetCallbacks(IMouseInputActions instance)
        {
            if (m_Wrapper.m_MouseInputActionsCallbackInterface != null)
            {
                @clickDown.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnClickDown;
                @clickDown.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnClickDown;
                @clickDown.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnClickDown;
                @ClickDownPos.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnClickDownPos;
                @ClickDownPos.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnClickDownPos;
                @ClickDownPos.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnClickDownPos;
            }
            m_Wrapper.m_MouseInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @clickDown.started += instance.OnClickDown;
                @clickDown.performed += instance.OnClickDown;
                @clickDown.canceled += instance.OnClickDown;
                @ClickDownPos.started += instance.OnClickDownPos;
                @ClickDownPos.performed += instance.OnClickDownPos;
                @ClickDownPos.canceled += instance.OnClickDownPos;
            }
        }
    }
    public MouseInputActions @MouseInput => new MouseInputActions(this);
    public interface IMouseInputActions
    {
        void OnClickDown(InputAction.CallbackContext context);
        void OnClickDownPos(InputAction.CallbackContext context);
    }
}
