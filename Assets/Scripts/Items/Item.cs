using Assets.Scripts.Interactions;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
namespace Assets.Scripts.Items
{
    public class Item : MonoBehaviour, IDraggable
    {
        [SerializeField] private ItemConfig _config;

        private Rigidbody _rigidBody;

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
        }

        public void Drag()
        {
            _rigidBody.useGravity = false;
        }

        public void Dragging(Vector3 moveDir, float draggingSpeed)
        {
            _rigidBody.velocity = moveDir * draggingSpeed;
        }

        public void Drop()
        {
            _rigidBody.useGravity = true;
        }

        public void Store(Transform transform)
        {
            transform.position = transform.position;
        }
    }
}
