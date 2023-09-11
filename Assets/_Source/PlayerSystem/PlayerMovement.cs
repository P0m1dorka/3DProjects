using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement
    {
        public void Move(Rigidbody rb, float speed, float inputH, float inputV)
        {
            rb.transform.position += new Vector3(inputH * speed, inputV * speed, inputH * speed);
            Debug.Log("Pivo");
        }
        public void Jump(Rigidbody rb, float jumpspeed)
        {
            rb.AddForce(0,1*jumpspeed,0,ForceMode.Impulse);
        }
    }
}
