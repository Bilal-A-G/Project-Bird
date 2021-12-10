// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""PC"",
            ""id"": ""c83511d8-f3cb-41b5-b31a-58513dbb4f30"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e3545c20-8669-4662-8b45-30fbd406542b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""744706cd-bfa9-4aa6-b802-7d78c436e326"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""39ad9223-0d6a-4713-81d6-404cab93f7e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5c2d5010-b968-47c4-a1aa-23f9cc6687e0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6e890d92-a130-4413-9c02-14a25fe9c7fe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""273484fa-bb3b-4476-911a-5a6abd5a17b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""67ae5a98-9270-4110-936e-a2072df470bc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""002454c3-31fd-4e5c-afe9-30d103c4af67"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79e80f3b-b506-46ef-81b3-c8fd11c7e175"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51be5312-0947-4587-b008-3bf2d2004412"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7b1a4cb-07d9-491a-9b61-8d21f1db3e8f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""MovementVector"",
                    ""id"": ""e0329c14-a476-418d-af0b-d6211cd5fda7"",
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
                    ""id"": ""9bc9cb94-703e-4ed3-b664-edd6f34a3c0d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""76169118-1673-4bb2-8557-cc27f8a06d29"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""def023a8-95f0-41cc-b9b6-01dae001f139"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4f5c5a7c-95ea-49e9-8322-7b1ef2bfb96f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9fa76547-a6a2-438e-8d22-4501b395a6e8"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f022a39-50ff-4b3c-bdd8-9637ffb99cb6"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PC
        m_PC = asset.FindActionMap("PC", throwIfNotFound: true);
        m_PC_Jump = m_PC.FindAction("Jump", throwIfNotFound: true);
        m_PC_Interact = m_PC.FindAction("Interact", throwIfNotFound: true);
        m_PC_Reload = m_PC.FindAction("Reload", throwIfNotFound: true);
        m_PC_Shoot = m_PC.FindAction("Shoot", throwIfNotFound: true);
        m_PC_Movement = m_PC.FindAction("Movement", throwIfNotFound: true);
        m_PC_MouseX = m_PC.FindAction("MouseX", throwIfNotFound: true);
        m_PC_MouseY = m_PC.FindAction("MouseY", throwIfNotFound: true);
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

    // PC
    private readonly InputActionMap m_PC;
    private IPCActions m_PCActionsCallbackInterface;
    private readonly InputAction m_PC_Jump;
    private readonly InputAction m_PC_Interact;
    private readonly InputAction m_PC_Reload;
    private readonly InputAction m_PC_Shoot;
    private readonly InputAction m_PC_Movement;
    private readonly InputAction m_PC_MouseX;
    private readonly InputAction m_PC_MouseY;
    public struct PCActions
    {
        private @InputActions m_Wrapper;
        public PCActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PC_Jump;
        public InputAction @Interact => m_Wrapper.m_PC_Interact;
        public InputAction @Reload => m_Wrapper.m_PC_Reload;
        public InputAction @Shoot => m_Wrapper.m_PC_Shoot;
        public InputAction @Movement => m_Wrapper.m_PC_Movement;
        public InputAction @MouseX => m_Wrapper.m_PC_MouseX;
        public InputAction @MouseY => m_Wrapper.m_PC_MouseY;
        public InputActionMap Get() { return m_Wrapper.m_PC; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PCActions set) { return set.Get(); }
        public void SetCallbacks(IPCActions instance)
        {
            if (m_Wrapper.m_PCActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PCActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_PCActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnInteract;
                @Reload.started -= m_Wrapper.m_PCActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnReload;
                @Shoot.started -= m_Wrapper.m_PCActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnShoot;
                @Movement.started -= m_Wrapper.m_PCActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnMovement;
                @MouseX.started -= m_Wrapper.m_PCActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_PCActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnMouseY;
            }
            m_Wrapper.m_PCActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
            }
        }
    }
    public PCActions @PC => new PCActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    public interface IPCActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
}
