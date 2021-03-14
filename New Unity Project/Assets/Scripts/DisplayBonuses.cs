﻿using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public sealed class DisplayBonuses
    {
        private Text _text;
        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
        }

        public void Display(int value)
        {
            _text.text = $"Вы набрали {value}";
        }
    }

}
