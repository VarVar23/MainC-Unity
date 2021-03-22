using System;
using UnityEngine;

namespace Game
{
    class Test : MonoBehaviour
    {
        private void Start()
        {
            var example = new ActionDelegateExample();

            example[UserAction.Up]();
            example[UserAction.Down]();
        }

    }
}
