//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scr_Runtime/Core_Input/InputController_Player.inputactions
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

public partial class @InputController_Player: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController_Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController_Player"",
    ""maps"": [
        {
            ""name"": ""World"",
            ""id"": ""a51b77b0-1ef6-456f-9990-ea708f703930"",
            ""actions"": [
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Value"",
                    ""id"": ""5e5ef751-a42e-41f0-83ef-e4fce5666d80"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Value"",
                    ""id"": ""806eb1fb-b325-4d8d-8414-10efdfc85e5c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Value"",
                    ""id"": ""815c947b-20ad-4147-bb2d-6fd1833b832c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Value"",
                    ""id"": ""20cc51f3-cc53-4e4b-9474-e3848b1ad7fb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""c6dbff6b-2768-4347-8acb-1a997e46b50c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PressE"",
                    ""type"": ""Button"",
                    ""id"": ""137bce1c-addb-4c6b-b8fa-bdc3bf6890a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PressEsc"",
                    ""type"": ""Button"",
                    ""id"": ""afb36752-6d59-4505-96c9-c5c190184a7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PressR"",
                    ""type"": ""Button"",
                    ""id"": ""4d2086c2-d5de-42ec-b7d8-df034dfe48ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a9488344-4b24-4c72-b8d0-a64ccfb54129"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""134b792e-15b3-4a82-b3df-cf98e0bd0ac7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ace6d7e-05de-4b64-83ec-95a393b096d5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8670a03-b96a-4c7a-bbd6-d8e992114437"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad06555f-4c1f-4006-9e71-8ca5f1ba76eb"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d034077-26c8-4cc7-8ad8-619f292e57f9"",
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
                    ""id"": ""1275b708-1cf7-4926-a5c0-f580eb971f1b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29f81eb1-de2b-4e8d-9161-64349bdd9f3d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6758df5f-f069-4832-b1b9-d7f451aa7d55"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a91ce981-2190-498f-ab10-9305c02a3213"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a039818-d050-4b59-9823-e92dc5daba30"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd273b95-deeb-4ac3-ad8d-96900e67d277"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01e93d3e-7bdb-47af-841c-30e4e75f65c5"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressEsc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""beec381d-6e0a-459f-87af-6fbd8b039ede"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // World
        m_World = asset.FindActionMap("World", throwIfNotFound: true);
        m_World_MoveUp = m_World.FindAction("MoveUp", throwIfNotFound: true);
        m_World_MoveDown = m_World.FindAction("MoveDown", throwIfNotFound: true);
        m_World_MoveLeft = m_World.FindAction("MoveLeft", throwIfNotFound: true);
        m_World_MoveRight = m_World.FindAction("MoveRight", throwIfNotFound: true);
        m_World_Jump = m_World.FindAction("Jump", throwIfNotFound: true);
        m_World_PressE = m_World.FindAction("PressE", throwIfNotFound: true);
        m_World_PressEsc = m_World.FindAction("PressEsc", throwIfNotFound: true);
        m_World_PressR = m_World.FindAction("PressR", throwIfNotFound: true);
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

    // World
    private readonly InputActionMap m_World;
    private List<IWorldActions> m_WorldActionsCallbackInterfaces = new List<IWorldActions>();
    private readonly InputAction m_World_MoveUp;
    private readonly InputAction m_World_MoveDown;
    private readonly InputAction m_World_MoveLeft;
    private readonly InputAction m_World_MoveRight;
    private readonly InputAction m_World_Jump;
    private readonly InputAction m_World_PressE;
    private readonly InputAction m_World_PressEsc;
    private readonly InputAction m_World_PressR;
    public struct WorldActions
    {
        private @InputController_Player m_Wrapper;
        public WorldActions(@InputController_Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveUp => m_Wrapper.m_World_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_World_MoveDown;
        public InputAction @MoveLeft => m_Wrapper.m_World_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_World_MoveRight;
        public InputAction @Jump => m_Wrapper.m_World_Jump;
        public InputAction @PressE => m_Wrapper.m_World_PressE;
        public InputAction @PressEsc => m_Wrapper.m_World_PressEsc;
        public InputAction @PressR => m_Wrapper.m_World_PressR;
        public InputActionMap Get() { return m_Wrapper.m_World; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WorldActions set) { return set.Get(); }
        public void AddCallbacks(IWorldActions instance)
        {
            if (instance == null || m_Wrapper.m_WorldActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WorldActionsCallbackInterfaces.Add(instance);
            @MoveUp.started += instance.OnMoveUp;
            @MoveUp.performed += instance.OnMoveUp;
            @MoveUp.canceled += instance.OnMoveUp;
            @MoveDown.started += instance.OnMoveDown;
            @MoveDown.performed += instance.OnMoveDown;
            @MoveDown.canceled += instance.OnMoveDown;
            @MoveLeft.started += instance.OnMoveLeft;
            @MoveLeft.performed += instance.OnMoveLeft;
            @MoveLeft.canceled += instance.OnMoveLeft;
            @MoveRight.started += instance.OnMoveRight;
            @MoveRight.performed += instance.OnMoveRight;
            @MoveRight.canceled += instance.OnMoveRight;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @PressE.started += instance.OnPressE;
            @PressE.performed += instance.OnPressE;
            @PressE.canceled += instance.OnPressE;
            @PressEsc.started += instance.OnPressEsc;
            @PressEsc.performed += instance.OnPressEsc;
            @PressEsc.canceled += instance.OnPressEsc;
            @PressR.started += instance.OnPressR;
            @PressR.performed += instance.OnPressR;
            @PressR.canceled += instance.OnPressR;
        }

        private void UnregisterCallbacks(IWorldActions instance)
        {
            @MoveUp.started -= instance.OnMoveUp;
            @MoveUp.performed -= instance.OnMoveUp;
            @MoveUp.canceled -= instance.OnMoveUp;
            @MoveDown.started -= instance.OnMoveDown;
            @MoveDown.performed -= instance.OnMoveDown;
            @MoveDown.canceled -= instance.OnMoveDown;
            @MoveLeft.started -= instance.OnMoveLeft;
            @MoveLeft.performed -= instance.OnMoveLeft;
            @MoveLeft.canceled -= instance.OnMoveLeft;
            @MoveRight.started -= instance.OnMoveRight;
            @MoveRight.performed -= instance.OnMoveRight;
            @MoveRight.canceled -= instance.OnMoveRight;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @PressE.started -= instance.OnPressE;
            @PressE.performed -= instance.OnPressE;
            @PressE.canceled -= instance.OnPressE;
            @PressEsc.started -= instance.OnPressEsc;
            @PressEsc.performed -= instance.OnPressEsc;
            @PressEsc.canceled -= instance.OnPressEsc;
            @PressR.started -= instance.OnPressR;
            @PressR.performed -= instance.OnPressR;
            @PressR.canceled -= instance.OnPressR;
        }

        public void RemoveCallbacks(IWorldActions instance)
        {
            if (m_Wrapper.m_WorldActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWorldActions instance)
        {
            foreach (var item in m_Wrapper.m_WorldActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WorldActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WorldActions @World => new WorldActions(this);
    public interface IWorldActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPressE(InputAction.CallbackContext context);
        void OnPressEsc(InputAction.CallbackContext context);
        void OnPressR(InputAction.CallbackContext context);
    }
}