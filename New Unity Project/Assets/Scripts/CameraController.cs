using System;
using UnityEngine;

namespace Game
{
    class CameraController : MonoBehaviour
    {
        public Player Player;
        private Vector3 _offset;
        private GoodBonus _gb;

        private void Start()
        {
            _offset = transform.position - Player.transform.position;
            _gb.BonusEvent += CameraStorm;
        }

        private void LateUpdate()
        {
            transform.position = Player.transform.position + _offset;
        }

        private void CameraStorm()
        {
            // тут должна трястись камера
        }
    }
}
