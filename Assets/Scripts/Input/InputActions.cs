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
                    ""name"": ""Left"",
                    ""type"": ""PassThrough"",
                    ""id"": ""720b6900-b0fa-4568-8784-a1c9703b151a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c8d0bf0d-5082-4524-9cc8-2e1e936f3f54"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Forwards"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3cb9d166-9d8f-413e-acf4-9748cc511df4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backwards"",
                    ""type"": ""PassThrough"",
                    ""id"": ""47bfd353-82a1-436b-a86d-8ac5eab16465"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9438bff7-22ac-4c5b-9996-14bd6576b2c0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcb553fb-a44c-4f07-a60d-9907c0b1ee3a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea9c6a6b-d417-4e3c-9d4f-3c1dc612e1c8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Forwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34b25167-b17b-4ce5-ac11-b1af490ae1b8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Backwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
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
        m_PC_Left = m_PC.FindAction("Left", throwIfNotFound: true);
        m_PC_Right = m_PC.FindAction("Right", throwIfNotFound: true);
        m_PC_Forwards = m_PC.FindAction("Forwards", throwIfNotFound: true);
        m_PC_Backwards = m_PC.FindAction("Backwards", throwIfNotFound: true);
        m_PC_Jump = m_PC.FindAction("Jump", throwIfNotFound: true);
        m_PC_Interact = m_PC.FindAction("Interact", throwIfNotFound: true);
        m_PC_Reload = m_PC.FindAction("Reload", throwIfNotFound: true);
        m_PC_Shoot = m_PC.FindAction("Shoot", throwIfNotFound: true);
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
    private readonly InputAction m_PC_Left;
    private readonly InputAction m_PC_Right;
    private readonly InputAction m_PC_Forwards;
    private readonly InputAction m_PC_Backwards;
    private readonly InputAction m_PC_Jump;
    private readonly InputAction m_PC_Interact;
    private readonly InputAction m_PC_Reload;
    private readonly InputAction m_PC_Shoot;
    public struct PCActions
    {
        private @InputActions m_Wrapper;
        public PCActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left => m_Wrapper.m_PC_Left;
        public InputAction @Right => m_Wrapper.m_PC_Right;
        public InputAction @Forwards => m_Wrapper.m_PC_Forwards;
        public InputAction @Backwards => m_Wrapper.m_PC_Backwards;
        public InputAction @Jump => m_Wrapper.m_PC_Jump;
        public InputAction @Interact => m_Wrapper.m_PC_Interact;
        public InputAction @Reload => m_Wrapper.m_PC_Reload;
        public InputAction @Shoot => m_Wrapper.m_PC_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_PC; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PCActions set) { return set.Get(); }
        public void SetCallbacks(IPCActions instance)
        {
            if (m_Wrapper.m_PCActionsCallbackInterface != null)
            {
                @Left.started -= m_Wrapper.m_PCActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_PCActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnRight;
                @Forwards.started -= m_Wrapper.m_PCActionsCallbackInterface.OnForwards;
                @Forwards.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnForwards;
                @Forwards.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnForwards;
                @Backwards.started -= m_Wrapper.m_PCActionsCallbackInterface.OnBackwards;
                @Backwards.performed -= m_Wrapper.m_PCActionsCallbackInterface.OnBackwards;
                @Backwards.canceled -= m_Wrapper.m_PCActionsCallbackInterface.OnBackwards;
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
            }
            m_Wrapper.m_PCActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Forwards.started += instance.OnForwards;
                @Forwards.performed += instance.OnForwards;
                @Forwards.canceled += instance.OnForwards;
                @Backwards.started += instance.OnBackwards;
                @Backwards.performed += instance.OnBackwards;
                @Backwards.canceled += instance.OnBackwards;
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
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnForwards(InputAction.CallbackContext context);
        void OnBackwards(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
