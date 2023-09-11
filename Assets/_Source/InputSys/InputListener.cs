using System;
using PlayerSystem;
using Unity.VisualScripting;
using UnityEngine;
namespace InputSys
{
    public class InputListener : MonoBehaviour
    {
        
        [SerializeField] private KeyCode JumpKey;
        private Player _player;
        private Invoker _invoker;

        private void Awake()
        {
            _invoker = new Invoker(_player);
        }

        private void Update()
        {
            
            ReadMove();
        }

        private void ShootKey()
        {
            //вызов метода шут из инвокера
        }
        private void ReadMove()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Debug.Log("sss");
            _invoker.Move(h,v);
        }
        private void ReedJumpKey()
        {
            if (Input.GetKeyDown(JumpKey))
            {
                Debug.Log("Jump");
            }
        }
        private void ReedEnterKey()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("Enter");
            }
        }
    }
}
