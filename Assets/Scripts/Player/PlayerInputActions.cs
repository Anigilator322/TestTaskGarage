//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Interaction"",
            ""id"": ""69bbd784-4919-44c3-8f4b-e5994fac3358"",
            ""actions"": [
                {
                    ""name"": ""LBM_Pressesd"",
                    ""type"": ""Button"",
                    ""id"": ""44f3f5b0-0b55-4fab-8225-7da57bd87eb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""1712288b-6da1-480e-bddd-1348ea7787d1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""07c0e0ce-a7d2-47f4-af69-1db74c825e33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bc1a8b50-6817-4d1c-b7c9-0c22fb574574"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC_Controll"",
                    ""action"": ""LBM_Pressesd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fc9cc69-9119-4608-8049-663623a60a30"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC_Controll"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00a2d0d4-8c6b-4818-992c-417598083fe3"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Movement"",
            ""id"": ""b30c3f70-c7f0-491a-abe9-1f92b0e08d2e"",
            ""actions"": [
                {
                    ""name"": ""MoveKeys"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e9c0fbee-158d-4c67-8d0f-9001a819cdc4"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""191f6bf5-9785-48ee-8258-00264d604145"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""408b6c7c-5a13-4e94-8a6d-6bae569f6e94"",
                    ""path"": ""3DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeys"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cd226923-0e17-48ab-ab8f-4c85f61ef311"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c0139817-bd11-4957-b0f7-6675b186b686"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""8d936651-dc43-4e91-88eb-bf4715886b88"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""1dbd06e3-e6ee-4776-b6c7-3b5f8f79d1d4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""X"",
                    ""id"": ""81edff45-1766-43ae-872f-b067e16a5d22"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""3ff0c71d-64bb-4da0-b3e8-e683afea66c7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""2c92a7f9-97ba-422f-b59c-2c3aa9208caa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Z"",
                    ""id"": ""9de6d55a-133c-46b8-966c-a1240d0a39dc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""a4409773-b26d-40c3-b0a2-501f6e81cce8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""7eb18f0a-7c7c-4e79-8d5d-64a6c9d07e5f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Rotation"",
            ""id"": ""2f3117d5-0e7c-446a-96ee-53dd2f1bb0b8"",
            ""actions"": [
                {
                    ""name"": ""RotationX"",
                    ""type"": ""Value"",
                    ""id"": ""959839eb-0791-4bdc-967d-d2b9e83678ab"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotationY"",
                    ""type"": ""Value"",
                    ""id"": ""ead8999a-038a-43fb-a73c-21c63087e157"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe405c51-0674-47b0-8e68-faf494a811b8"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2a8feb0-b4e8-4b01-a5c5-fb8a65f4a77f"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC_Controll"",
            ""bindingGroup"": ""PC_Controll"",
            ""devices"": []
        }
    ]
}");
        // Interaction
        m_Interaction = asset.FindActionMap("Interaction", throwIfNotFound: true);
        m_Interaction_LBM_Pressesd = m_Interaction.FindAction("LBM_Pressesd", throwIfNotFound: true);
        m_Interaction_MousePosition = m_Interaction.FindAction("MousePosition", throwIfNotFound: true);
        m_Interaction_Interact = m_Interaction.FindAction("Interact", throwIfNotFound: true);
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_MoveKeys = m_Movement.FindAction("MoveKeys", throwIfNotFound: true);
        m_Movement_WASD = m_Movement.FindAction("WASD", throwIfNotFound: true);
        // Rotation
        m_Rotation = asset.FindActionMap("Rotation", throwIfNotFound: true);
        m_Rotation_RotationX = m_Rotation.FindAction("RotationX", throwIfNotFound: true);
        m_Rotation_RotationY = m_Rotation.FindAction("RotationY", throwIfNotFound: true);
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

    // Interaction
    private readonly InputActionMap m_Interaction;
    private List<IInteractionActions> m_InteractionActionsCallbackInterfaces = new List<IInteractionActions>();
    private readonly InputAction m_Interaction_LBM_Pressesd;
    private readonly InputAction m_Interaction_MousePosition;
    private readonly InputAction m_Interaction_Interact;
    public struct InteractionActions
    {
        private @PlayerInputActions m_Wrapper;
        public InteractionActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LBM_Pressesd => m_Wrapper.m_Interaction_LBM_Pressesd;
        public InputAction @MousePosition => m_Wrapper.m_Interaction_MousePosition;
        public InputAction @Interact => m_Wrapper.m_Interaction_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Interaction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionActions set) { return set.Get(); }
        public void AddCallbacks(IInteractionActions instance)
        {
            if (instance == null || m_Wrapper.m_InteractionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InteractionActionsCallbackInterfaces.Add(instance);
            @LBM_Pressesd.started += instance.OnLBM_Pressesd;
            @LBM_Pressesd.performed += instance.OnLBM_Pressesd;
            @LBM_Pressesd.canceled += instance.OnLBM_Pressesd;
            @MousePosition.started += instance.OnMousePosition;
            @MousePosition.performed += instance.OnMousePosition;
            @MousePosition.canceled += instance.OnMousePosition;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(IInteractionActions instance)
        {
            @LBM_Pressesd.started -= instance.OnLBM_Pressesd;
            @LBM_Pressesd.performed -= instance.OnLBM_Pressesd;
            @LBM_Pressesd.canceled -= instance.OnLBM_Pressesd;
            @MousePosition.started -= instance.OnMousePosition;
            @MousePosition.performed -= instance.OnMousePosition;
            @MousePosition.canceled -= instance.OnMousePosition;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(IInteractionActions instance)
        {
            if (m_Wrapper.m_InteractionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInteractionActions instance)
        {
            foreach (var item in m_Wrapper.m_InteractionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InteractionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InteractionActions @Interaction => new InteractionActions(this);

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_MoveKeys;
    private readonly InputAction m_Movement_WASD;
    public struct MovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public MovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveKeys => m_Wrapper.m_Movement_MoveKeys;
        public InputAction @WASD => m_Wrapper.m_Movement_WASD;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @MoveKeys.started += instance.OnMoveKeys;
            @MoveKeys.performed += instance.OnMoveKeys;
            @MoveKeys.canceled += instance.OnMoveKeys;
            @WASD.started += instance.OnWASD;
            @WASD.performed += instance.OnWASD;
            @WASD.canceled += instance.OnWASD;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @MoveKeys.started -= instance.OnMoveKeys;
            @MoveKeys.performed -= instance.OnMoveKeys;
            @MoveKeys.canceled -= instance.OnMoveKeys;
            @WASD.started -= instance.OnWASD;
            @WASD.performed -= instance.OnWASD;
            @WASD.canceled -= instance.OnWASD;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Rotation
    private readonly InputActionMap m_Rotation;
    private List<IRotationActions> m_RotationActionsCallbackInterfaces = new List<IRotationActions>();
    private readonly InputAction m_Rotation_RotationX;
    private readonly InputAction m_Rotation_RotationY;
    public struct RotationActions
    {
        private @PlayerInputActions m_Wrapper;
        public RotationActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotationX => m_Wrapper.m_Rotation_RotationX;
        public InputAction @RotationY => m_Wrapper.m_Rotation_RotationY;
        public InputActionMap Get() { return m_Wrapper.m_Rotation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RotationActions set) { return set.Get(); }
        public void AddCallbacks(IRotationActions instance)
        {
            if (instance == null || m_Wrapper.m_RotationActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RotationActionsCallbackInterfaces.Add(instance);
            @RotationX.started += instance.OnRotationX;
            @RotationX.performed += instance.OnRotationX;
            @RotationX.canceled += instance.OnRotationX;
            @RotationY.started += instance.OnRotationY;
            @RotationY.performed += instance.OnRotationY;
            @RotationY.canceled += instance.OnRotationY;
        }

        private void UnregisterCallbacks(IRotationActions instance)
        {
            @RotationX.started -= instance.OnRotationX;
            @RotationX.performed -= instance.OnRotationX;
            @RotationX.canceled -= instance.OnRotationX;
            @RotationY.started -= instance.OnRotationY;
            @RotationY.performed -= instance.OnRotationY;
            @RotationY.canceled -= instance.OnRotationY;
        }

        public void RemoveCallbacks(IRotationActions instance)
        {
            if (m_Wrapper.m_RotationActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRotationActions instance)
        {
            foreach (var item in m_Wrapper.m_RotationActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RotationActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RotationActions @Rotation => new RotationActions(this);
    private int m_PC_ControllSchemeIndex = -1;
    public InputControlScheme PC_ControllScheme
    {
        get
        {
            if (m_PC_ControllSchemeIndex == -1) m_PC_ControllSchemeIndex = asset.FindControlSchemeIndex("PC_Controll");
            return asset.controlSchemes[m_PC_ControllSchemeIndex];
        }
    }
    public interface IInteractionActions
    {
        void OnLBM_Pressesd(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IMovementActions
    {
        void OnMoveKeys(InputAction.CallbackContext context);
        void OnWASD(InputAction.CallbackContext context);
    }
    public interface IRotationActions
    {
        void OnRotationX(InputAction.CallbackContext context);
        void OnRotationY(InputAction.CallbackContext context);
    }
}
