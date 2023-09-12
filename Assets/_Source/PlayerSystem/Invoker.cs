using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Invoker
{
    private PlayerMovement _playerMovement;
    private Player _player;
    private PlayerCombat playerCombat;

    public Invoker(Player player)
    {
        _player = player;
        
        _playerMovement = new PlayerMovement();
        playerCombat = new PlayerCombat();
    }
    public void Move(float horizontal,float vertical)
    {
        _playerMovement.Move(_player.rb,_player.speed,horizontal,vertical);
    }
    public void Jump()
    {
        _playerMovement.Jump(_player.rb,_player.jumpSpeed);
    }
    public void Rotate(float horizontal)
    {
        _playerMovement.Rotate(_player.rb,horizontal,_player.rotSpeed);
    }
    public void Shoot()
    {
        playerCombat.Shoot(_player.bulletSpawn,_player.bulletPref);
    }
}
