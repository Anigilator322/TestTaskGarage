using Assets.Scripts.Interactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;
namespace Assets.Scripts.Player
{
    public class PlayerInteraction : MonoBehaviour
    {
        [Inject] private PlayerInputActions _playerInputActions;
        [SerializeField] private Camera _mainCamera;
        [SerializeField] private float _distanceToInteract;
        private void Awake()
        {
            _playerInputActions.Interaction.Enable();
            _playerInputActions.Interaction.Interact.performed += InteractWith;
        }
        private void InteractWith(InputAction.CallbackContext context)
        {
            Vector2 mousePos = _playerInputActions.Interaction.MousePosition.ReadValue<Vector2>();
            Ray ray = _mainCamera.ScreenPointToRay(mousePos);
            RaycastHit hit;
            Debug.Log("interact");
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    if (hit.distance <= _distanceToInteract)
                    {
                        Debug.Log("interact2");
                        if (TryGetComponent<IInteractable>(out IInteractable interactable))
                        {
                            Debug.Log("interact3");
                            interactable.Interact();
                        }
                    }
                }
            }

        }
    }
}
