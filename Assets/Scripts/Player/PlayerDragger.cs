using Assets.Scripts.Interactions;
using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Assets.Scripts.Player
{
    public class PlayerDragger : MonoBehaviour
    {
        [Inject] private PlayerInputActions _playerInputActions;
        [SerializeField] private Camera _mainCamera;

        [SerializeField] private float _distanceToHandleObject;
        [SerializeField] private float _handleOffset;
        [SerializeField] private float _draggingSpeed;
        private bool _dragging;

        public Action<Vector3, float> OnDragging;
        public Action OnDrop;

        private void Awake()
        {
            _playerInputActions.Interaction.Enable();
            _playerInputActions.Interaction.LBM_Pressesd.performed += MousePressed;
            _playerInputActions.Interaction.LBM_Pressesd.canceled += _ => _dragging = false;
        }

        private void MousePressed(InputAction.CallbackContext context)
        {
            Vector2 mousePos = _playerInputActions.Interaction.MousePosition.ReadValue<Vector2>();
            Ray ray = _mainCamera.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider!=null)
                {
                    if(hit.distance<=_distanceToHandleObject)
                    {
                        if (hit.collider.gameObject.TryGetComponent<IDraggable>(out IDraggable draggable))
                        {
                            _dragging = true;
                            draggable.Drag();
                            OnDragging += draggable.Dragging;
                            OnDrop += draggable.Drop;
                            StartCoroutine(Dragging(hit.collider.gameObject));
                        }
                    }
                }
            }
        }

        private IEnumerator Dragging(GameObject draggable)
        {
            
            while (_dragging)
            {
                Ray ray = _mainCamera.ScreenPointToRay(_playerInputActions.Interaction.MousePosition.ReadValue<Vector2>());
                Debug.Log("Dragging");
                Vector3 movedir = ray.GetPoint(_handleOffset) - draggable.transform.position;
                OnDragging?.Invoke(movedir,_draggingSpeed);
                yield return new WaitForFixedUpdate();
            }
            OnDrop?.Invoke();
        }
    }
}
