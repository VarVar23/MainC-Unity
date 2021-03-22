using System;
using UnityEngine;

namespace Game
{
    class MyExeption : Exception
    {
        public GameObject Player;

        private void Start()
        {
            try
            {
                if (Player.transform.position.y < -100)
                {
                    throw new MyExeption();
                }
            }
            catch
            {
                Debug.LogError("Игрок находится на отрицательных координатах");
            }

        }
    }
}
