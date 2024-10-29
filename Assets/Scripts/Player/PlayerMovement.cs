using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using Zenject;
namespace Assets.Scripts.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Inject] private PlayerInputActions _playerInputActions;
        private Rigidbody _rigidbody;

        [SerializeField] private float _movementSpeed;
        private bool _isMoving = false;

        void Awake()
        {
            _playerInputActions.Movement.Enable();
            _rigidbody = GetComponent<Rigidbody>();
            _playerInputActions.Movement.MoveKeys.performed += _ => _isMoving = true;
            _playerInputActions.Movement.MoveKeys.canceled += _ => _isMoving = false;
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            if (_isMoving)
            {
                Vector3 _movementDirection = _playerInputActions.Movement.MoveKeys.ReadValue<Vector3>();
                Vector3 horizontalVelocity = transform.right * _movementDirection.x + transform.forward * _movementDirection.z;
                _rigidbody.velocity = horizontalVelocity * _movementSpeed;
            }
        }
    }
}
