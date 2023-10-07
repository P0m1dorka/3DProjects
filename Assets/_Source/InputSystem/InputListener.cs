using System;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private Game _game;
     
        public void Construct(Game game)
        {
            _game = game;
        }
        private void Update()
        {
         //   _game.OnApplicationExit();
        }
    }
}
