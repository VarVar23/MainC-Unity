using UnityEngine.UI;
using System;

namespace Game
{
    class DisplayEndGame
    {
        private Text _finishGameLabel;
        public DisplayEndGame(Text finishGameLabel)
        {
            _finishGameLabel = finishGameLabel;
            _finishGameLabel.text = String.Empty;
        }

        public void GameOver(object o)
        {
            _finishGameLabel.text = "Вы проиграли";
        }
    }
}
