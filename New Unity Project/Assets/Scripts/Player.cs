using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Player : MonoBehaviour
    {
        [SerializeField] float _speed;
        private Rigidbody _rb;
        private Vector3 _spawnPoint;
        public int Score = 0;

        public Player()
        {
            Debug.Log("Player");
        }

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _spawnPoint = transform.position;
        }

        private void FixedUpdate()
        {
            Move();
            Death();
        }
        protected void Move()
        {
            float horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * _speed;
            float verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * _speed;

            Vector3 move = new Vector3(horizontalMove, 0, verticalMove);

            _rb.AddForce(move * _speed);
        }

        private void Death()
        {
            if(transform.position.y < -5f)
            {
                transform.position = _spawnPoint;
            }
        }
    }
}

