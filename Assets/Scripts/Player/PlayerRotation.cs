using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Animations;
using Zenject;
namespace Assets.Scripts.Player
{
    public class PlayerRotation : MonoBehaviour
    {
        [Inject] private PlayerInputActions _playerInputActions;

        [SerializeField] private float _rotationSpeed;
        [SerializeField] private Rigidbody _orientation;
        [SerializeField] private Camera _camera;
        
        
        void Awake()
        {
            _playerInputActions.Rotation.Enable();

            _camera.gameObject.transform.rotation = Quaternion.identity;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        void FixedUpdate()
        {
            Rotate();
        }
        
        private void Rotate()
        {

            float RotationX = _rotationSpeed * _playerInputActions.Rotation.RotationX.ReadValue<float>() * Time.deltaTime;
            float RotationY = _rotationSpeed * _playerInputActions.Rotation.RotationY.ReadValue<float>() * Time.deltaTime;
            Vector3 CamRotation = _camera.gameObject.transform.rotation.eulerAngles;

            CamRotation.x -= RotationY;
            CamRotation.y += RotationX;

            _camera.gameObject.transform.rotation = Quaternion.Euler(CamRotation);
            _orientation.rotation = Quaternion.Euler(0, CamRotation.y, 0);
            
        }
    }
}
