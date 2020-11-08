// GENERATED AUTOMATICALLY FROM 'Assets/DoubTech/TPSCharacterController/Configuration/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace DoubTech.TPSCharacterController.Inputs
{
    public class @InputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b5320493-b43c-4d0a-9b12-79f3f356356e"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""76bf9285-382c-4cee-a1d1-812c4b43adec"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""36f0f77a-f098-42fa-8ffb-3c1b5e5c8864"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""eaa7d4ff-3098-4f7a-8af1-7bb5b6f4e6e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""62007c0d-1531-4f2e-8830-79f1d0c75701"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""08317053-9534-42ff-a365-f27f8bce0403"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Combat Direction"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6e37309a-ee8b-42cb-a42d-b7cea6709d4d"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Axis Combat Direction"",
                    ""type"": ""PassThrough"",
                    ""id"": ""431805bc-8b89-4c21-8b11-9756cee92cd8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackStrong"",
                    ""type"": ""Button"",
                    ""id"": ""3d02750e-bac0-4607-9b99-dfb902fcc6e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackWeak"",
                    ""type"": ""Button"",
                    ""id"": ""1f827265-4aed-4178-a4d6-55ffc9fa174a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""25c5746b-dc78-41fe-a953-5a1193133100"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Equip"",
                    ""type"": ""Button"",
                    ""id"": ""42a6a14a-4128-4491-a29f-e37e6f18f66b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""0dcb3da0-8bb9-4e20-985c-2b8787439683"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""6906e8ca-1cb5-45c8-9376-1af0fa9b5ace"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""89be3ed7-fb84-41da-8530-512d99793177"",
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
                    ""id"": ""b13f29f2-cb00-4812-9d7c-c6399e008a3f"",
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
                    ""id"": ""6f76b73f-a9f9-47f5-92e7-4d44e2268553"",
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
                    ""id"": ""4a88d539-61ed-466d-a666-cf2946f9e98a"",
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
                    ""id"": ""750222da-31cf-49de-9f19-c8046fc6958a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""30f6a892-e27e-4ded-aa92-80106360ea13"",
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
                    ""id"": ""f970bbf5-29aa-4a8e-9b92-d1feec9a1b93"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8151d47c-e801-4e0f-8327-59dba0b0b5f9"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2459bcee-bd8d-4af9-9a96-43a2be3d26d4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""88f07e1f-028b-45be-a393-f3aa23cfac52"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""995d2faf-d030-41ac-bf61-c4c9346a9126"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5e2b203-c816-4dd1-94ab-09014c6399a1"",
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
                    ""id"": ""81f363a1-55bf-406d-855b-42cdc8470db9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08dbf56c-7972-4205-b5d0-12cda66294d7"",
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
                    ""id"": ""4c2b48db-907e-4b58-92dc-c81c15a47103"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3047e51-c539-48d3-a335-d7c0218bc086"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbe308a6-d7a0-4e86-92fc-073e6bb1e303"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c291403b-e881-4d76-b4a2-3cb0cc364beb"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b53fef5-0ce8-4c12-bc34-d1af4e9580c7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackStrong"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81ba9a77-ae19-45b2-a2d7-8a518e65991a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackStrong"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee02a9c7-adc8-4f23-9491-81f393125b99"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d70b3fe-c341-4c58-8506-53b317020727"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d23ba68-be7f-44e5-9d36-24b36db0913e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9de1768-092c-4b57-b390-46c2d32b0781"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f99fff04-df32-41ca-b288-be867f949dc0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackWeak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa1304e6-ee6e-48be-9df2-c34f5251e088"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackWeak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c91b0f5f-6141-4957-977e-0a47a09042c5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0c01a31-1a26-415e-8fc2-5d00213f50f4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ad8d7ce6-7b25-47bd-9dc6-54b205130346"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3f17e802-e60e-4e48-97f0-3267777dc9e5"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c038c568-9881-4858-92ae-07a865ee0128"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3ba76d4e-8258-4eed-b37d-9860f31862d7"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8de1afed-75fe-4af1-87f1-1d8791b33358"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""bd878b86-a554-49fc-ade0-d741ed600eed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""df61353b-cf55-48be-b62d-4a5f4afac135"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cee1f894-91fb-4ede-8173-aa7934fdaac7"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4d12f1c0-4684-4d21-b8b4-a9a1cab86287"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dbae2dbd-6962-4454-96af-65e4d4f54d46"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combat Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c972fd6a-e86d-480f-acfd-0fba87ba34fc"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis Combat Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc6f8c92-e295-4dac-ab38-97073c20a887"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1eaa17fe-9257-4845-b2c4-9da9b285abf0"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
            m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
            m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
            m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
            m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
            m_Player_CombatDirection = m_Player.FindAction("Combat Direction", throwIfNotFound: true);
            m_Player_AxisCombatDirection = m_Player.FindAction("Axis Combat Direction", throwIfNotFound: true);
            m_Player_AttackStrong = m_Player.FindAction("AttackStrong", throwIfNotFound: true);
            m_Player_AttackWeak = m_Player.FindAction("AttackWeak", throwIfNotFound: true);
            m_Player_Block = m_Player.FindAction("Block", throwIfNotFound: true);
            m_Player_Equip = m_Player.FindAction("Equip", throwIfNotFound: true);
            m_Player_Use = m_Player.FindAction("Use", throwIfNotFound: true);
            m_Player_Throw = m_Player.FindAction("Throw", throwIfNotFound: true);
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

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Movement;
        private readonly InputAction m_Player_Look;
        private readonly InputAction m_Player_Jump;
        private readonly InputAction m_Player_Run;
        private readonly InputAction m_Player_Crouch;
        private readonly InputAction m_Player_CombatDirection;
        private readonly InputAction m_Player_AxisCombatDirection;
        private readonly InputAction m_Player_AttackStrong;
        private readonly InputAction m_Player_AttackWeak;
        private readonly InputAction m_Player_Block;
        private readonly InputAction m_Player_Equip;
        private readonly InputAction m_Player_Use;
        private readonly InputAction m_Player_Throw;
        public struct PlayerActions
        {
            private @InputActions m_Wrapper;
            public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Player_Movement;
            public InputAction @Look => m_Wrapper.m_Player_Look;
            public InputAction @Jump => m_Wrapper.m_Player_Jump;
            public InputAction @Run => m_Wrapper.m_Player_Run;
            public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
            public InputAction @CombatDirection => m_Wrapper.m_Player_CombatDirection;
            public InputAction @AxisCombatDirection => m_Wrapper.m_Player_AxisCombatDirection;
            public InputAction @AttackStrong => m_Wrapper.m_Player_AttackStrong;
            public InputAction @AttackWeak => m_Wrapper.m_Player_AttackWeak;
            public InputAction @Block => m_Wrapper.m_Player_Block;
            public InputAction @Equip => m_Wrapper.m_Player_Equip;
            public InputAction @Use => m_Wrapper.m_Player_Use;
            public InputAction @Throw => m_Wrapper.m_Player_Throw;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                    @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                    @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                    @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @CombatDirection.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCombatDirection;
                    @CombatDirection.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCombatDirection;
                    @CombatDirection.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCombatDirection;
                    @AxisCombatDirection.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAxisCombatDirection;
                    @AxisCombatDirection.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAxisCombatDirection;
                    @AxisCombatDirection.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAxisCombatDirection;
                    @AttackStrong.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackStrong;
                    @AttackStrong.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackStrong;
                    @AttackStrong.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackStrong;
                    @AttackWeak.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackWeak;
                    @AttackWeak.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackWeak;
                    @AttackWeak.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttackWeak;
                    @Block.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                    @Block.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                    @Block.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                    @Equip.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquip;
                    @Equip.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquip;
                    @Equip.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquip;
                    @Use.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUse;
                    @Use.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUse;
                    @Use.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUse;
                    @Throw.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrow;
                    @Throw.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrow;
                    @Throw.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrow;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Run.started += instance.OnRun;
                    @Run.performed += instance.OnRun;
                    @Run.canceled += instance.OnRun;
                    @Crouch.started += instance.OnCrouch;
                    @Crouch.performed += instance.OnCrouch;
                    @Crouch.canceled += instance.OnCrouch;
                    @CombatDirection.started += instance.OnCombatDirection;
                    @CombatDirection.performed += instance.OnCombatDirection;
                    @CombatDirection.canceled += instance.OnCombatDirection;
                    @AxisCombatDirection.started += instance.OnAxisCombatDirection;
                    @AxisCombatDirection.performed += instance.OnAxisCombatDirection;
                    @AxisCombatDirection.canceled += instance.OnAxisCombatDirection;
                    @AttackStrong.started += instance.OnAttackStrong;
                    @AttackStrong.performed += instance.OnAttackStrong;
                    @AttackStrong.canceled += instance.OnAttackStrong;
                    @AttackWeak.started += instance.OnAttackWeak;
                    @AttackWeak.performed += instance.OnAttackWeak;
                    @AttackWeak.canceled += instance.OnAttackWeak;
                    @Block.started += instance.OnBlock;
                    @Block.performed += instance.OnBlock;
                    @Block.canceled += instance.OnBlock;
                    @Equip.started += instance.OnEquip;
                    @Equip.performed += instance.OnEquip;
                    @Equip.canceled += instance.OnEquip;
                    @Use.started += instance.OnUse;
                    @Use.performed += instance.OnUse;
                    @Use.canceled += instance.OnUse;
                    @Throw.started += instance.OnThrow;
                    @Throw.performed += instance.OnThrow;
                    @Throw.canceled += instance.OnThrow;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnRun(InputAction.CallbackContext context);
            void OnCrouch(InputAction.CallbackContext context);
            void OnCombatDirection(InputAction.CallbackContext context);
            void OnAxisCombatDirection(InputAction.CallbackContext context);
            void OnAttackStrong(InputAction.CallbackContext context);
            void OnAttackWeak(InputAction.CallbackContext context);
            void OnBlock(InputAction.CallbackContext context);
            void OnEquip(InputAction.CallbackContext context);
            void OnUse(InputAction.CallbackContext context);
            void OnThrow(InputAction.CallbackContext context);
        }
    }
}
