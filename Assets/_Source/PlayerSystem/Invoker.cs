namespace PlayerSystem
{
    public class Invoker
    {
        private PlayerMovement _playerMovement;
        private Player _player;
        private PlayerCombat _playerCombat;
        public Invoker(Player player)
        {
            _player = player;
            _playerMovement = new PlayerMovement();
            _playerCombat = new PlayerCombat();
        }
        public void Move(float inputH, float inputV)
        {
         _playerMovement.Move(_player.Rb,_player.movementSpeed,inputH,inputV);   
        }
        public void Shoot()
        {
            _playerCombat.Shoot(_player.firePoint,_player.bulletPrefab);
        }
    }
}
