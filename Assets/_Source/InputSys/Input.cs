using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Input : MonoBehaviour
{
    private float _x;
    private float _v;
    private Invoker _invoker;
   [SerializeField] private bool _input = true;
   [SerializeField] private Player _player;
   [SerializeField] private BulletPhysic _bullet;
   [SerializeField] private TMP_Text _text;
    private void Awake()
    {
        _invoker = new Invoker(_player,_bullet);
    }
    void Update()
    {
        if (_input)
        {
            Move();
            Jump();
            Shoot();
        }
        else
        {
            
        }
        TurnInput();
    }

    private void TurnInput()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Return) && _input)
        {
            _input = false;
            _text.text = "Input = false";
        }
        else if (UnityEngine.Input.GetKeyDown(KeyCode.Return) && !_input)
        {
            _input = true;
            _text.text = "Input = true";
        }
    }
    private void Move()
    {
        _x = UnityEngine.Input.GetAxis("Horizontal");
        _v = UnityEngine.Input.GetAxis("Vertical");
        _invoker.Move(_x,_v);
        Rotate(_x);
    }
    private void Jump()
    {
        if (UnityEngine.Input.GetKeyUp(KeyCode.Space))
        {
            _invoker.Jump();
        }
    }
    private void Rotate(float horizontal)
    {
        _invoker.Rotate(horizontal);
    }
    private void Shoot()
    {
        if(UnityEngine.Input.GetKeyUp(KeyCode.Q))
            _invoker.Shoot();
    }
    
}
