using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Player;
using UnityEngine;
using Zenject;
namespace Assets.Scripts.Cam
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private PlayerUnit _player;

        private void Update()
        {
            transform.position = _player.CameraHolder.position;
        }
    }
}
