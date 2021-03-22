
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public sealed class GoodBonus : InteractiveObject, IFlicker, IFly
    {
        public delegate void BonusDelegate();
        public event BonusDelegate BonusEvent;

        private Material _material;
        private float _lengthFly;
        private DisplayBonuses _displayBonuses;
        public int Point;

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFly = Random.Range(1.0f, 5.0f);
        }
        protected override void Interaction()
        {
            _displayBonuses.Display(1);
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthFly), transform.localPosition.z);
            BonusEvent?.Invoke();
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,Mathf.PingPong(Time.time, 1.0f));
            BonusEvent?.Invoke();
        }

    }
}
